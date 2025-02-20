// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkPublicIPResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_WorkloadNetworksGetPublicIP()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetPublicIP.json
            // this example is just showing the usage of "WorkloadNetworks_GetPublicIP" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkPublicIPResource created on azure
            // for more information of creating WorkloadNetworkPublicIPResource, please refer to the document of WorkloadNetworkPublicIPResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string publicIPId = "publicIP1";
            ResourceIdentifier workloadNetworkPublicIPResourceId = WorkloadNetworkPublicIPResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, publicIPId);
            WorkloadNetworkPublicIPResource workloadNetworkPublicIP = client.GetWorkloadNetworkPublicIPResource(workloadNetworkPublicIPResourceId);

            // invoke the operation
            WorkloadNetworkPublicIPResource result = await workloadNetworkPublicIP.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkPublicIPData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_WorkloadNetworksDeletePublicIP()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_DeletePublicIP.json
            // this example is just showing the usage of "WorkloadNetworks_DeletePublicIP" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkPublicIPResource created on azure
            // for more information of creating WorkloadNetworkPublicIPResource, please refer to the document of WorkloadNetworkPublicIPResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string publicIPId = "publicIP1";
            ResourceIdentifier workloadNetworkPublicIPResourceId = WorkloadNetworkPublicIPResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, publicIPId);
            WorkloadNetworkPublicIPResource workloadNetworkPublicIP = client.GetWorkloadNetworkPublicIPResource(workloadNetworkPublicIPResourceId);

            // invoke the operation
            await workloadNetworkPublicIP.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_WorkloadNetworksCreatePublicIP()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_CreatePublicIP.json
            // this example is just showing the usage of "WorkloadNetworks_CreatePublicIP" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkPublicIPResource created on azure
            // for more information of creating WorkloadNetworkPublicIPResource, please refer to the document of WorkloadNetworkPublicIPResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string publicIPId = "publicIP1";
            ResourceIdentifier workloadNetworkPublicIPResourceId = WorkloadNetworkPublicIPResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, publicIPId);
            WorkloadNetworkPublicIPResource workloadNetworkPublicIP = client.GetWorkloadNetworkPublicIPResource(workloadNetworkPublicIPResourceId);

            // invoke the operation
            WorkloadNetworkPublicIPData data = new WorkloadNetworkPublicIPData
            {
                DisplayName = "publicIP1",
                NumberOfPublicIPs = 32L,
            };
            ArmOperation<WorkloadNetworkPublicIPResource> lro = await workloadNetworkPublicIP.UpdateAsync(WaitUntil.Completed, data);
            WorkloadNetworkPublicIPResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkPublicIPData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
