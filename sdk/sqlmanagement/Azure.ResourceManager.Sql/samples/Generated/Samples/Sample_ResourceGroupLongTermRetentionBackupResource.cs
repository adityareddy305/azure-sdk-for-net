// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ResourceGroupLongTermRetentionBackupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ResourceGroupBasedLongTermRetentionBackupGet.json
            // this example is just showing the usage of "LongTermRetentionBackups_GetByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupLongTermRetentionBackupResource created on azure
            // for more information of creating ResourceGroupLongTermRetentionBackupResource, please refer to the document of ResourceGroupLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testResourceGroup";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000;Archive";
            ResourceIdentifier resourceGroupLongTermRetentionBackupResourceId = ResourceGroupLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            ResourceGroupLongTermRetentionBackupResource resourceGroupLongTermRetentionBackup = client.GetResourceGroupLongTermRetentionBackupResource(resourceGroupLongTermRetentionBackupResourceId);

            // invoke the operation
            ResourceGroupLongTermRetentionBackupResource result = await resourceGroupLongTermRetentionBackup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LongTermRetentionBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ResourceGroupBasedLongTermRetentionBackupDelete.json
            // this example is just showing the usage of "LongTermRetentionBackups_DeleteByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupLongTermRetentionBackupResource created on azure
            // for more information of creating ResourceGroupLongTermRetentionBackupResource, please refer to the document of ResourceGroupLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testResourceGroup";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000;Archive";
            ResourceIdentifier resourceGroupLongTermRetentionBackupResourceId = ResourceGroupLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            ResourceGroupLongTermRetentionBackupResource resourceGroupLongTermRetentionBackup = client.GetResourceGroupLongTermRetentionBackupResource(resourceGroupLongTermRetentionBackupResourceId);

            // invoke the operation
            await resourceGroupLongTermRetentionBackup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ChangeAccessTierByResourceGroup_ChangeTheLongTermRetentionBackupStorageAccessTierForAResourceGroup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ResourceGroupBasedChangeLongTermRetentionBackupAccessTier.json
            // this example is just showing the usage of "LongTermRetentionBackups_ChangeAccessTierByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupLongTermRetentionBackupResource created on azure
            // for more information of creating ResourceGroupLongTermRetentionBackupResource, please refer to the document of ResourceGroupLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroupName";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "serverName";
            string longTermRetentionDatabaseName = "databaseName";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000;Archive";
            ResourceIdentifier resourceGroupLongTermRetentionBackupResourceId = ResourceGroupLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            ResourceGroupLongTermRetentionBackupResource resourceGroupLongTermRetentionBackup = client.GetResourceGroupLongTermRetentionBackupResource(resourceGroupLongTermRetentionBackupResourceId);

            // invoke the operation
            ChangeLongTermRetentionBackupAccessTierParameters changeLongTermRetentionBackupAccessTierParameters = new ChangeLongTermRetentionBackupAccessTierParameters("Hot", "Copy");
            ArmOperation<ResourceGroupLongTermRetentionBackupResource> lro = await resourceGroupLongTermRetentionBackup.ChangeAccessTierByResourceGroupAsync(WaitUntil.Completed, changeLongTermRetentionBackupAccessTierParameters);
            ResourceGroupLongTermRetentionBackupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LongTermRetentionBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CopyByResourceGroup_CopyTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ResourceGroupBasedLongTermRetentionBackupCopy.json
            // this example is just showing the usage of "LongTermRetentionBackups_CopyByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupLongTermRetentionBackupResource created on azure
            // for more information of creating ResourceGroupLongTermRetentionBackupResource, please refer to the document of ResourceGroupLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testResourceGroup";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000";
            ResourceIdentifier resourceGroupLongTermRetentionBackupResourceId = ResourceGroupLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            ResourceGroupLongTermRetentionBackupResource resourceGroupLongTermRetentionBackup = client.GetResourceGroupLongTermRetentionBackupResource(resourceGroupLongTermRetentionBackupResourceId);

            // invoke the operation
            CopyLongTermRetentionBackupContent content = new CopyLongTermRetentionBackupContent
            {
                TargetServerResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/providers/Microsoft.Sql/resourceGroups/resourceGroup/servers/testserver2"),
                TargetDatabaseName = "testDatabase2",
                TargetBackupStorageRedundancy = SqlBackupStorageRedundancy.Geo,
            };
            ArmOperation<LongTermRetentionBackupOperationResult> lro = await resourceGroupLongTermRetentionBackup.CopyByResourceGroupAsync(WaitUntil.Completed, content);
            LongTermRetentionBackupOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateByResourceGroup_UpdateTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ResourceGroupBasedLongTermRetentionBackupUpdate.json
            // this example is just showing the usage of "LongTermRetentionBackups_UpdateByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupLongTermRetentionBackupResource created on azure
            // for more information of creating ResourceGroupLongTermRetentionBackupResource, please refer to the document of ResourceGroupLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testResourceGroup";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000";
            ResourceIdentifier resourceGroupLongTermRetentionBackupResourceId = ResourceGroupLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            ResourceGroupLongTermRetentionBackupResource resourceGroupLongTermRetentionBackup = client.GetResourceGroupLongTermRetentionBackupResource(resourceGroupLongTermRetentionBackupResourceId);

            // invoke the operation
            UpdateLongTermRetentionBackupContent content = new UpdateLongTermRetentionBackupContent
            {
                RequestedBackupStorageRedundancy = SqlBackupStorageRedundancy.Geo,
            };
            ArmOperation<LongTermRetentionBackupOperationResult> lro = await resourceGroupLongTermRetentionBackup.UpdateByResourceGroupAsync(WaitUntil.Completed, content);
            LongTermRetentionBackupOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
