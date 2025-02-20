// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceRegistry.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DeviceRegistry.Samples
{
    public partial class Sample_DeviceRegistrySchemaResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SchemasGet()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Schema.json
            // this example is just showing the usage of "Schema_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistrySchemaResource created on azure
            // for more information of creating DeviceRegistrySchemaResource, please refer to the document of DeviceRegistrySchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            ResourceIdentifier deviceRegistrySchemaResourceId = DeviceRegistrySchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName);
            DeviceRegistrySchemaResource deviceRegistrySchema = client.GetDeviceRegistrySchemaResource(deviceRegistrySchemaResourceId);

            // invoke the operation
            DeviceRegistrySchemaResource result = await deviceRegistrySchema.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistrySchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteSchema()
        {
            // Generated from example definition: 2024-09-01-preview/Delete_Schema.json
            // this example is just showing the usage of "Schema_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistrySchemaResource created on azure
            // for more information of creating DeviceRegistrySchemaResource, please refer to the document of DeviceRegistrySchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            ResourceIdentifier deviceRegistrySchemaResourceId = DeviceRegistrySchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName);
            DeviceRegistrySchemaResource deviceRegistrySchema = client.GetDeviceRegistrySchemaResource(deviceRegistrySchemaResourceId);

            // invoke the operation
            await deviceRegistrySchema.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateSchema()
        {
            // Generated from example definition: 2024-09-01-preview/Create_Schema.json
            // this example is just showing the usage of "Schema_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistrySchemaResource created on azure
            // for more information of creating DeviceRegistrySchemaResource, please refer to the document of DeviceRegistrySchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            ResourceIdentifier deviceRegistrySchemaResourceId = DeviceRegistrySchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName);
            DeviceRegistrySchemaResource deviceRegistrySchema = client.GetDeviceRegistrySchemaResource(deviceRegistrySchemaResourceId);

            // invoke the operation
            DeviceRegistrySchemaData data = new DeviceRegistrySchemaData
            {
                Properties = new DeviceRegistrySchemaProperties(DeviceRegistrySchemaFormat.JsonSchemaDraft7, DeviceRegistrySchemaType.MessageSchema)
                {
                    DisplayName = "My Schema",
                    Description = "This is a sample Schema",
                    Tags =
{
["sampleKey"] = "sampleValue"
},
                },
            };
            ArmOperation<DeviceRegistrySchemaResource> lro = await deviceRegistrySchema.UpdateAsync(WaitUntil.Completed, data);
            DeviceRegistrySchemaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistrySchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
