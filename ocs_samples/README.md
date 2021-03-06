# OCS Samples
OSIsoft Cloud Services ([OCS](https://www.osisoft.com/Solutions/OSIsoft-Cloud-Services/)) is a highly flexible cloud-based platform that provides scalable, elastic,
centralized environment to aggregate data for reporting, advanced analytics, and third-party applications.  OCS is powered by OSIsoft's Sequential Data Store (SDS). In this GitHub repo, we provide samples which will help you get started with the [OCS API](https://ocs-docs.osisoft.com/) against your [OCS instance](https://cloud.osisoft.com/welcome).

There are three types of samples/apps in the repo:

* <img src="../miscellaneous/images/app-type-getting-started.png" alt="getting-started icon">  Getting Started - OCS focused samples for a task, usually implemented as a simple console app.  This also includes base libraries that may be used in other apps.

* <img src="../miscellaneous/images/app-type-ingress.png" alt="ingress icon">   Ingress apps - Real world examples of applications focused on sending data to OCS.  

* <img src="../miscellaneous/images/app-type-e2e.png" alt="e2e icon">   End-End apps - Real world examples of web, desktop, mobile, and other applications using OCS data.  

Some tasks and individual language examples may have some additional labels as follows:

* \* denotes that the language example uses the rest API directily instead of a library

* <img src="../miscellaneous/images/ctp.png" alt="ctp icon">   This task and code uses services that are currently in preview.  If you are interested in this functionality, please contact OCS support.  



The official OCS samples are divided in multiple categories depending on the scenario and problem/task, accessible through the following table:


Task|Description|Languages|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Test&nbsp;Status&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
----|-----------|---------|-----------
**<a href="basic_samples/Authentication/">Authentication</a>**  <img src="../miscellaneous/images/app-type-getting-started.png" alt="getting-started icon"> | **Client Credential** <a href="basic_samples/Authentication/">Details</a> <br /> **Hybrid Authentication** <a href="basic_samples/Authentication/">Details</a> <br /> **Implicit Authentication** <a href="basic_samples/Authentication/">Details</a> <br /> **Authorization Code Flow** <a href="basic_samples/Authentication/">Details</a>  | <a href="basic_samples/Authentication/ClientCredentialFlow/DotNet/ClientCredentialFlow">.NET</a> <br /> <a href="basic_samples/Authentication/HybridFlow/DotNet/HybridFlow">.NET</a><br /><a href="basic_samples/Authentication/ImplicitFlow/DotNet/ImplicitFlow">.NET and JavaScript</a> <br /><a href="basic_samples/Authentication/AuthorizationCodeFlow/DotNet/AuthorizationCodeFlow">.NET and JavaScript</a>| [![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=Auth_CC_DotNet)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master)<br /> [![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=Auth_Hybrid_DotNet)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master) <br /> [![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=Auth_Implicit_DotNet)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master) <br /> [![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=Auth_PKCE_DotNet)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4561&branchName=master)
**<a href="basic_samples/SDS">Types, Streams, and retreiving Data -- WaveForm</a>** <img src="../miscellaneous/images/app-type-getting-started.png" alt="getting-started icon"> | Covers some typical operations against the SDS, including client credential authentication, creating, updating, and deleting types, streams and events.  This uses a non-time Series Type.  Some tasks are different from the other "Types, Streams, and retreiving Data" task, so look at the task readme for details.  This is a recommended starting example, and a good a base for all other Tasks.  <a href="basic_samples/SDS">Details</a> | <a href="basic_samples/SDS/DotNet/SdsClientLibraries/SdsClientLibraries">.NET</a><br /><a href="basic_samples/SDS/DotNet/SdsRestApiCore">.NET*</a><br /><a href="basic_samples/SDS/Java/sdsjava">JAVA</a><br /><a href="basic_samples/SDS/JavaScript/Angular">Angular</a><br /><a href="basic_samples/SDS/JavaScript/NodeJs">nodeJS</a><br /><a href="basic_samples/SDS/Python/SDSPy/Python3">Python3</a> | [![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=SDSDotNet)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master) <br />[![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=SDSDotNetAPI)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master) <br /> [![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=SDSJava)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master) <br /> [![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=SDSangJS)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master) <br />[![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=SDSnodeJS)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master) <br /> [![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=SDSPy)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master)
**<a href="basic_samples/SDS_TimeSeries">Types, Streams, and retreiving Data -- Time-Series</a>** <img src="../miscellaneous/images/app-type-getting-started.png" alt="getting-started icon"> | Covers some typical operations against the SDS, including client credential authentication, creating, and deleting types and streams.  This sample is based on Time-Series data.  Some tasks are different from the other "Types, Streams, and retreiving Data" task, so look at the task readme for details.  This is a recommended starting example, and a good a base for all other Tasks.  <a href="basic_samples/SDS_TimeSeries">Details</a>| <a href="basic_samples/SDS_TimeSeries/Python">Python</a> <br /> <a href="basic_samples/SDS_TimeSeries/DotNet/Try">DotNet</a>|[![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=SDS_TSPy)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master)<br />[![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=SDS_TSDotNet)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master)
**<a href="advanced_samples/UomsSample/Dotnet/UomsSample/UomsSample">UOM</a>** <img src="../miscellaneous/images/app-type-getting-started.png" alt="getting-started icon"> | Covers the basic functionality of the UOM system on OCS | <a href="advanced_samples/UomsSample/Dotnet/UomsSample/UomsSample">.NET</a>&nbsp; &nbsp; | [![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=UOM_DotNet)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master)
**<a href="library_samples/">Sample Libraries</a>** <img src="../miscellaneous/images/app-type-getting-started.png" alt="getting-started icon"> | These sample libraries are used as the base for the other samples.  They are designed to be straightforward implementations of the REST APIs.  They are for use in the samples.  <a href="library_samples/">Details</a>|  <a href="library_samples/Java/ocs_sample_library_preview/">Java</a><br /><a href="library_samples/Python3/">Python3</a>| ~~ <br /> ~~
<img src="../miscellaneous/images/ctp.png" alt="ctp icon">  **<a href="basic_samples/Dataviews/">Dataviews</a>** <img src="../miscellaneous/images/app-type-getting-started.png" alt="getting-started icon"> | These samples highlight basic operations of Dataviews for OCS, including creation, updating, getting data from and deletion of dataviews.  <a href="basic_samples/Dataviews">Details</a> |  <a href="basic_samples/Dataviews/Java/dataviewjava">Java</a><br /><a href="basic_samples/Dataviews/Python3">Python3</a>|[![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=DataviewJava)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master)<br />[![Build Status](https://osisoft.visualstudio.com/Engineering%20Incubation/_apis/build/status/OSIsoft_OCS_Samples-CI?branchName=master&jobName=DataviewPy)](https://osisoft.visualstudio.com/Engineering%20Incubation/_build/latest?definitionId=4334&branchName=master)

~~ These libraries are tested by being used in other apps.
   
   Note: Angular test fails commonly due to automatation issues
   



For sending OMF to OCS please see the OMF area: <a href="../omf_samples/">omf_samples</a> <br />
For the main landing page on master [ReadMe](https://github.com/osisoft/OSI-Samples)

## Credentials 

A credential config.ini or app.config file is used in the examples unless otherwise noted in the example.  
   

     Note: This is not a secure way to store credentials.  This is to be used at your own risk.  
   
   
   You will need to modify these files locally when you run the samples.


## Feedback

If you have a need for a new sample; if there is a feature or capability that should be demonstrated; if there is an existing sample that should be in your favorite language; please reach out to us and give us feedback at https://feedback.osisoft.com under the OSIsoft GitHub Channel.  [Feedback](https://feedback.osisoft.com/forums/922279-osisoft-github).   
 
## Support

If your support question or issue is related to something with an OSIsoft product (an error message, a problem with product configuration, etc...), please open a case with OSIsoft Tech Support through myOSIsoft Customer Portal  (https://my.osisoft.com).

If your support question or issue is related to a non-modified sample (or test) or documentation for the sample; please email Samples@osisoft.com.

## License

[OSI Samples](https://github.com/osisoft/OSI-Samples) are licensed under the [Apache 2 license](../LICENSE.md).
