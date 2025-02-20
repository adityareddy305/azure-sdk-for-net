// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBTableResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBTableGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBTableGet.json
            // this example is just showing the usage of "TableResources_GetTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBTableResource created on azure
            // for more information of creating CosmosDBTableResource, please refer to the document of CosmosDBTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string tableName = "tableName";
            ResourceIdentifier cosmosDBTableResourceId = CosmosDBTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, tableName);
            CosmosDBTableResource cosmosDBTable = client.GetCosmosDBTableResource(cosmosDBTableResourceId);

            // invoke the operation
            CosmosDBTableResource result = await cosmosDBTable.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_CosmosDBTableDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBTableDelete.json
            // this example is just showing the usage of "TableResources_DeleteTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBTableResource created on azure
            // for more information of creating CosmosDBTableResource, please refer to the document of CosmosDBTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string tableName = "tableName";
            ResourceIdentifier cosmosDBTableResourceId = CosmosDBTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, tableName);
            CosmosDBTableResource cosmosDBTable = client.GetCosmosDBTableResource(cosmosDBTableResourceId);

            // invoke the operation
            await cosmosDBTable.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CosmosDBTableReplace()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBTableCreateUpdate.json
            // this example is just showing the usage of "TableResources_CreateUpdateTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBTableResource created on azure
            // for more information of creating CosmosDBTableResource, please refer to the document of CosmosDBTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string tableName = "tableName";
            ResourceIdentifier cosmosDBTableResourceId = CosmosDBTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, tableName);
            CosmosDBTableResource cosmosDBTable = client.GetCosmosDBTableResource(cosmosDBTableResourceId);

            // invoke the operation
            CosmosDBTableCreateOrUpdateContent content = new CosmosDBTableCreateOrUpdateContent(new AzureLocation("West US"), new CosmosDBTableResourceInfo("tableName"))
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags = { },
            };
            ArmOperation<CosmosDBTableResource> lro = await cosmosDBTable.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBTableResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RetrieveContinuousBackupInformation_CosmosDBTableCollectionBackupInformation()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBTableBackupInformation.json
            // this example is just showing the usage of "TableResources_RetrieveContinuousBackupInformation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBTableResource created on azure
            // for more information of creating CosmosDBTableResource, please refer to the document of CosmosDBTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string tableName = "tableName1";
            ResourceIdentifier cosmosDBTableResourceId = CosmosDBTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, tableName);
            CosmosDBTableResource cosmosDBTable = client.GetCosmosDBTableResource(cosmosDBTableResourceId);

            // invoke the operation
            ContinuousBackupRestoreLocation location = new ContinuousBackupRestoreLocation
            {
                Location = new AzureLocation("North Europe"),
            };
            ArmOperation<CosmosDBBackupInformation> lro = await cosmosDBTable.RetrieveContinuousBackupInformationAsync(WaitUntil.Completed, location);
            CosmosDBBackupInformation result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
