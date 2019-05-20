﻿using OSIsoft.Data.Http;
using OSIsoft.Identity;
using OSIsoft.OmfIngress.Contracts;
using OSIsoft.OmfIngress.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static OSIsoft.OmfIngress.Models.SubscriptionTypeEnum;

namespace OmfIngressClientLibraries
{
    class OmfIngressClient
    {
        private readonly IIngressService _ingressService;
        private readonly string _tenantId;
        private readonly string _namespaceId;

        public OmfIngressClient(string address, string tenantId, string namespaceId, string clientId, string clientSecret)
        {
            //Get Ingress Services to communicate with server and handle ingress management
            AuthenticationHandler authenticationHandler = new AuthenticationHandler(new Uri(address), clientId, clientSecret);
            _tenantId = tenantId;
            _namespaceId = namespaceId;
            IngressService baseIngressService = new IngressService(new Uri(address), null, HttpCompressionMethod.None, authenticationHandler);
            _ingressService = baseIngressService.GetIngressService(tenantId, namespaceId);
        }

        public async Task<OmfConnection> CreateOmfConnectionAsync(string deviceClientId, string connectionName, string destinationNamespaceId)
        {
            // Create a Topic
            Console.WriteLine($"Creating a Topic in Namespace {_namespaceId} for Client with Id {deviceClientId}");
            Console.WriteLine();
            Topic topic = new Topic()
            {
                TenantId = _tenantId,
                NamespaceId = _namespaceId,
                Name = connectionName,
                Description = "This is a sample Topic",
                ClientIds = new List<string>() { deviceClientId }
            };
            Topic createdTopic = await _ingressService.CreateTopicAsync(topic);
            Console.WriteLine($"Created a Topic with Id {createdTopic.Id}");
            Console.WriteLine();

            // Create a Subscription
            Console.WriteLine($"Creating an OCS Subscription in Namespace {_namespaceId} for Topic with Id {createdTopic.Id}");
            Console.WriteLine();
            Subscription subscription = new Subscription()
            {
                TenantId = _tenantId,
                NamespaceId = destinationNamespaceId,
                Name = $"{connectionName}-{destinationNamespaceId}",
                Description = "This is a sample OCS Data Store Subscription",
                Type = SubscriptionType.Sds,
                TopicId = createdTopic.Id,
                TopicTenantId = createdTopic.TenantId,
                TopicNamespaceId = createdTopic.NamespaceId
            };
            Subscription createdSubscription = await _ingressService.CreateSubscriptionAsync(subscription);
            Console.WriteLine($"Created an OCS Subscription with Id {createdSubscription.Id}");
            Console.WriteLine();
            OmfConnection omfConnection = new OmfConnection()
            {
                ClientIds = new string[] { deviceClientId },
                Topic = topic,
                Subscription = subscription
            };
            return omfConnection;
        }

        public async Task DeleteOmfConnectionAsync(OmfConnection omfConnection)
        {
            Console.WriteLine($"Deleting the OCS Subscription with Id {omfConnection.Subscription.Id}");
            Console.WriteLine();

            await _ingressService.DeleteSubscriptionAsync(omfConnection.Subscription.Id);

            Console.WriteLine($"Deleted the OCS Subscription with Id {omfConnection.Subscription.Id}");
            Console.WriteLine();

            // Delete the Topic
            Console.WriteLine($"Deleting the Topic with Id {omfConnection.Topic.Id}");
            Console.WriteLine();

            await _ingressService.DeleteTopicAsync(omfConnection.Topic.Id);

            Console.WriteLine($"Deleted the Topic with Id {omfConnection.Topic.Id}");
            Console.WriteLine();
        }
    }
}
