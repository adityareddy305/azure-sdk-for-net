// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerService.Samples
{
    public partial class Sample_ManagedClusterUpgradeProfileResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetUpgradeProfileForManagedCluster()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/ManagedClustersGetUpgradeProfile.json
            // this example is just showing the usage of "ManagedClusters_GetUpgradeProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedClusterUpgradeProfileResource created on azure
            // for more information of creating ManagedClusterUpgradeProfileResource, please refer to the document of ManagedClusterUpgradeProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier managedClusterUpgradeProfileResourceId = ManagedClusterUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ManagedClusterUpgradeProfileResource managedClusterUpgradeProfile = client.GetManagedClusterUpgradeProfileResource(managedClusterUpgradeProfileResourceId);

            // invoke the operation
            ManagedClusterUpgradeProfileResource result = await managedClusterUpgradeProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedClusterUpgradeProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
