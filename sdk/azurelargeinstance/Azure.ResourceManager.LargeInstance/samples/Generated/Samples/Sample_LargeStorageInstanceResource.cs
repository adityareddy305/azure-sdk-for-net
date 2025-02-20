// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.LargeInstance.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.LargeInstance.Samples
{
    public partial class Sample_LargeStorageInstanceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AzureLargeStorageInstanceGet()
        {
            // Generated from example definition: specification/azurelargeinstance/resource-manager/Microsoft.AzureLargeInstance/preview/2023-07-20-preview/examples/AzureLargeStorageInstance_Get.json
            // this example is just showing the usage of "AzureLargeStorageInstance_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LargeStorageInstanceResource created on azure
            // for more information of creating LargeStorageInstanceResource, please refer to the document of LargeStorageInstanceResource
            string subscriptionId = "f0f4887f-d13c-4943-a8ba-d7da28d2a3fd";
            string resourceGroupName = "myResourceGroup";
            string azureLargeStorageInstanceName = "myAzureLargeStorageInstance";
            ResourceIdentifier largeStorageInstanceResourceId = LargeStorageInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureLargeStorageInstanceName);
            LargeStorageInstanceResource largeStorageInstance = client.GetLargeStorageInstanceResource(largeStorageInstanceResourceId);

            // invoke the operation
            LargeStorageInstanceResource result = await largeStorageInstance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LargeStorageInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_AzureLargeStorageInstanceDeleteTag()
        {
            // Generated from example definition: specification/azurelargeinstance/resource-manager/Microsoft.AzureLargeInstance/preview/2023-07-20-preview/examples/AzureLargeStorageInstance_PatchTags_Delete.json
            // this example is just showing the usage of "AzureLargeStorageInstance_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LargeStorageInstanceResource created on azure
            // for more information of creating LargeStorageInstanceResource, please refer to the document of LargeStorageInstanceResource
            string subscriptionId = "f0f4887f-d13c-4943-a8ba-d7da28d2a3fd";
            string resourceGroupName = "myResourceGroup";
            string azureLargeStorageInstanceName = "myALSInstance";
            ResourceIdentifier largeStorageInstanceResourceId = LargeStorageInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureLargeStorageInstanceName);
            LargeStorageInstanceResource largeStorageInstance = client.GetLargeStorageInstanceResource(largeStorageInstanceResourceId);

            // invoke the operation
            LargeStorageInstancePatch patch = new LargeStorageInstancePatch();
            LargeStorageInstanceResource result = await largeStorageInstance.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LargeStorageInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_AzureLargeStorageInstanceUpdateTag()
        {
            // Generated from example definition: specification/azurelargeinstance/resource-manager/Microsoft.AzureLargeInstance/preview/2023-07-20-preview/examples/AzureLargeStorageInstance_PatchTags.json
            // this example is just showing the usage of "AzureLargeStorageInstance_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LargeStorageInstanceResource created on azure
            // for more information of creating LargeStorageInstanceResource, please refer to the document of LargeStorageInstanceResource
            string subscriptionId = "f0f4887f-d13c-4943-a8ba-d7da28d2a3fd";
            string resourceGroupName = "myResourceGroup";
            string azureLargeStorageInstanceName = "myALSInstance";
            ResourceIdentifier largeStorageInstanceResourceId = LargeStorageInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureLargeStorageInstanceName);
            LargeStorageInstanceResource largeStorageInstance = client.GetLargeStorageInstanceResource(largeStorageInstanceResourceId);

            // invoke the operation
            LargeStorageInstancePatch patch = new LargeStorageInstancePatch();
            LargeStorageInstanceResource result = await largeStorageInstance.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LargeStorageInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
