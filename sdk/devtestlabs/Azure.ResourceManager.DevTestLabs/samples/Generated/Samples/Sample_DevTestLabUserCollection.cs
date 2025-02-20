// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevTestLabs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DevTestLabs.Samples
{
    public partial class Sample_DevTestLabUserCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_UsersCreateOrUpdate()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Users_CreateOrUpdate.json
            // this example is just showing the usage of "Users_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{devtestlabName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabUserResource
            DevTestLabUserCollection collection = devTestLab.GetDevTestLabUsers();

            // invoke the operation
            string name = "{userName}";
            DevTestLabUserData data = new DevTestLabUserData(new AzureLocation("{location}"))
            {
                Identity = new DevTestLabUserIdentity
                {
                    PrincipalName = "{principalName}",
                    PrincipalId = "{principalId}",
                    TenantId = Guid.Parse("{tenantId}"),
                    ObjectId = "{objectId}",
                    AppId = "{appId}",
                },
                SecretStore = new DevTestLabUserSecretStore
                {
                    KeyVaultUri = new Uri("{keyVaultUri}"),
                    KeyVaultId = new ResourceIdentifier("{keyVaultId}"),
                },
                Tags =
{
["tagName1"] = "tagValue1"
},
            };
            ArmOperation<DevTestLabUserResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            DevTestLabUserResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabUserData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_UsersGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Users_Get.json
            // this example is just showing the usage of "Users_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{devtestlabName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabUserResource
            DevTestLabUserCollection collection = devTestLab.GetDevTestLabUsers();

            // invoke the operation
            string name = "{userName}";
            DevTestLabUserResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabUserData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_UsersList()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Users_List.json
            // this example is just showing the usage of "Users_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{devtestlabName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabUserResource
            DevTestLabUserCollection collection = devTestLab.GetDevTestLabUsers();

            // invoke the operation and iterate over the result
            await foreach (DevTestLabUserResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevTestLabUserData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_UsersGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Users_Get.json
            // this example is just showing the usage of "Users_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{devtestlabName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabUserResource
            DevTestLabUserCollection collection = devTestLab.GetDevTestLabUsers();

            // invoke the operation
            string name = "{userName}";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_UsersGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Users_Get.json
            // this example is just showing the usage of "Users_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{devtestlabName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabUserResource
            DevTestLabUserCollection collection = devTestLab.GetDevTestLabUsers();

            // invoke the operation
            string name = "{userName}";
            NullableResponse<DevTestLabUserResource> response = await collection.GetIfExistsAsync(name);
            DevTestLabUserResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevTestLabUserData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
