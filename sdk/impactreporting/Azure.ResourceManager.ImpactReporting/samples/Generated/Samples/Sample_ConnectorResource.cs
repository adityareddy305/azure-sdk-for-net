// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ImpactReporting.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ImpactReporting.Samples
{
    public partial class Sample_ConnectorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ConnectorsGet()
        {
            // Generated from example definition: 2024-05-01-preview/Connectors_Get.json
            // this example is just showing the usage of "Connector_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectorResource created on azure
            // for more information of creating ConnectorResource, please refer to the document of ConnectorResource
            string subscriptionId = "74f5e23f-d4d9-410a-bb4d-8f0608adb10d";
            string connectorName = "testconnector1";
            ResourceIdentifier connectorResourceId = ConnectorResource.CreateResourceIdentifier(subscriptionId, connectorName);
            ConnectorResource connector = client.GetConnectorResource(connectorResourceId);

            // invoke the operation
            ConnectorResource result = await connector.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ConnectorsDelete()
        {
            // Generated from example definition: 2024-05-01-preview/Connectors_Delete.json
            // this example is just showing the usage of "Connector_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectorResource created on azure
            // for more information of creating ConnectorResource, please refer to the document of ConnectorResource
            string subscriptionId = "8F74B371-8573-4773-9BDA-D546505BDB3A";
            string connectorName = "testconnector1";
            ResourceIdentifier connectorResourceId = ConnectorResource.CreateResourceIdentifier(subscriptionId, connectorName);
            ConnectorResource connector = client.GetConnectorResource(connectorResourceId);

            // invoke the operation
            await connector.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ConnectorsUpdate()
        {
            // Generated from example definition: 2024-05-01-preview/Connectors_Update.json
            // this example is just showing the usage of "Connector_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectorResource created on azure
            // for more information of creating ConnectorResource, please refer to the document of ConnectorResource
            string subscriptionId = "74f5e23f-d4d9-410a-bb4d-8f0608adb10d";
            string connectorName = "testconnector1";
            ResourceIdentifier connectorResourceId = ConnectorResource.CreateResourceIdentifier(subscriptionId, connectorName);
            ConnectorResource connector = client.GetConnectorResource(connectorResourceId);

            // invoke the operation
            ConnectorPatch patch = new ConnectorPatch
            {
                ConnectorType = Platform.AzureMonitor,
            };
            ConnectorResource result = await connector.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
