// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetApp.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppVolumeQuotaRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_VolumeQuotaRulesCreate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-09-01/examples/VolumeQuotaRules_Create.json
            // this example is just showing the usage of "VolumeQuotaRules_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "5275316f-a498-48d6-b324-2cbfdc4311b9";
            string resourceGroupName = "myRG";
            string accountName = "account-9957";
            string poolName = "pool-5210";
            string volumeName = "volume-6387";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeQuotaRuleResource
            NetAppVolumeQuotaRuleCollection collection = netAppVolume.GetNetAppVolumeQuotaRules();

            // invoke the operation
            string volumeQuotaRuleName = "rule-0004";
            NetAppVolumeQuotaRuleData data = new NetAppVolumeQuotaRuleData(new AzureLocation("westus"))
            {
                QuotaSizeInKiBs = 100005L,
                QuotaType = NetAppVolumeQuotaType.IndividualUserQuota,
                QuotaTarget = "1821",
            };
            ArmOperation<NetAppVolumeQuotaRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, volumeQuotaRuleName, data);
            NetAppVolumeQuotaRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeQuotaRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_VolumeQuotaRulesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-09-01/examples/VolumeQuotaRules_Get.json
            // this example is just showing the usage of "VolumeQuotaRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "5275316f-a498-48d6-b324-2cbfdc4311b9";
            string resourceGroupName = "myRG";
            string accountName = "account-9957";
            string poolName = "pool-5210";
            string volumeName = "volume-6387";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeQuotaRuleResource
            NetAppVolumeQuotaRuleCollection collection = netAppVolume.GetNetAppVolumeQuotaRules();

            // invoke the operation
            string volumeQuotaRuleName = "rule-0004";
            NetAppVolumeQuotaRuleResource result = await collection.GetAsync(volumeQuotaRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeQuotaRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_VolumeQuotaRulesList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-09-01/examples/VolumeQuotaRules_List.json
            // this example is just showing the usage of "VolumeQuotaRules_ListByVolume" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "5275316f-a498-48d6-b324-2cbfdc4311b9";
            string resourceGroupName = "myRG";
            string accountName = "account-9957";
            string poolName = "pool-5210";
            string volumeName = "volume-6387";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeQuotaRuleResource
            NetAppVolumeQuotaRuleCollection collection = netAppVolume.GetNetAppVolumeQuotaRules();

            // invoke the operation and iterate over the result
            await foreach (NetAppVolumeQuotaRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppVolumeQuotaRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_VolumeQuotaRulesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-09-01/examples/VolumeQuotaRules_Get.json
            // this example is just showing the usage of "VolumeQuotaRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "5275316f-a498-48d6-b324-2cbfdc4311b9";
            string resourceGroupName = "myRG";
            string accountName = "account-9957";
            string poolName = "pool-5210";
            string volumeName = "volume-6387";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeQuotaRuleResource
            NetAppVolumeQuotaRuleCollection collection = netAppVolume.GetNetAppVolumeQuotaRules();

            // invoke the operation
            string volumeQuotaRuleName = "rule-0004";
            bool result = await collection.ExistsAsync(volumeQuotaRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_VolumeQuotaRulesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-09-01/examples/VolumeQuotaRules_Get.json
            // this example is just showing the usage of "VolumeQuotaRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "5275316f-a498-48d6-b324-2cbfdc4311b9";
            string resourceGroupName = "myRG";
            string accountName = "account-9957";
            string poolName = "pool-5210";
            string volumeName = "volume-6387";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeQuotaRuleResource
            NetAppVolumeQuotaRuleCollection collection = netAppVolume.GetNetAppVolumeQuotaRules();

            // invoke the operation
            string volumeQuotaRuleName = "rule-0004";
            NullableResponse<NetAppVolumeQuotaRuleResource> response = await collection.GetIfExistsAsync(volumeQuotaRuleName);
            NetAppVolumeQuotaRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppVolumeQuotaRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
