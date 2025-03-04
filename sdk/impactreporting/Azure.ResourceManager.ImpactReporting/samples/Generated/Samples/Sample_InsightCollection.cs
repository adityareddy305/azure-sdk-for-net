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
    public partial class Sample_InsightCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatingAnInsight()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Create.json
            // this example is just showing the usage of "Insight_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid22";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "insightId12";
            InsightData data = new InsightData
            {
                Properties = new InsightProperties("repair", new Content("Impact Has been correlated to an outage", "At 2018-11-08T00:00:00Z UTC, your services dependent on these resources <link href=”…”>VM1</link> may have experienced an issue. <br/><div>We have identified an outage that affected these resources(s). You can look at outage information on <link href=\"https:// portal.azure.com/#view/Microsoft_Azure_Health/AzureHealthBrowseBlade/~/serviceIssues/trackingId/NL2W-VCZ\">NL2W-VCZ</link> link.<div>"), "00000000-0000-0000-0000-000000000000", new ImpactDetails("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resource-rg/providers/Microsoft.Sql/sqlserver/dbservername", DateTimeOffset.Parse("2023-06-15T01:00:00.009223Z"), "/subscriptions/00000000-0000-0000-0000-000000000000/providers/microsoft.Impact/workloadImpacts/impactid22"))
                {
                    Status = "resolved",
                    EventOn = DateTimeOffset.Parse("2023-06-15T04:00:00.009223Z"),
                },
            };
            ArmOperation<InsightResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, insightName, data);
            InsightResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InsightData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetInsightSampleForDiagnosticsCategory()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Get_diagnostics.json
            // this example is just showing the usage of "Insight_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "insight1";
            InsightResource result = await collection.GetAsync(insightName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InsightData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetInsightSampleForMitigationActionCategory()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Get_mitigationAction.json
            // this example is just showing the usage of "Insight_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactId";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "HPCUASucceeded";
            InsightResource result = await collection.GetAsync(insightName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InsightData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetInsightSampleForServiceHealthCategory()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Get_servicehealth.json
            // this example is just showing the usage of "Insight_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "insightname";
            InsightResource result = await collection.GetAsync(insightName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InsightData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListInsightResourcesByWorkloadImpactName()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_ListBySubscription.json
            // this example is just showing the usage of "Insight_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid22";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation and iterate over the result
            await foreach (InsightResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InsightData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetInsightSampleForDiagnosticsCategory()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Get_diagnostics.json
            // this example is just showing the usage of "Insight_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "insight1";
            bool result = await collection.ExistsAsync(insightName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetInsightSampleForMitigationActionCategory()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Get_mitigationAction.json
            // this example is just showing the usage of "Insight_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactId";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "HPCUASucceeded";
            bool result = await collection.ExistsAsync(insightName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetInsightSampleForServiceHealthCategory()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Get_servicehealth.json
            // this example is just showing the usage of "Insight_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "insightname";
            bool result = await collection.ExistsAsync(insightName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetInsightSampleForDiagnosticsCategory()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Get_diagnostics.json
            // this example is just showing the usage of "Insight_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "insight1";
            NullableResponse<InsightResource> response = await collection.GetIfExistsAsync(insightName);
            InsightResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InsightData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetInsightSampleForMitigationActionCategory()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Get_mitigationAction.json
            // this example is just showing the usage of "Insight_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactId";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "HPCUASucceeded";
            NullableResponse<InsightResource> response = await collection.GetIfExistsAsync(insightName);
            InsightResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InsightData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetInsightSampleForServiceHealthCategory()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Get_servicehealth.json
            // this example is just showing the usage of "Insight_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // get the collection of this InsightResource
            InsightCollection collection = workloadImpact.GetInsights();

            // invoke the operation
            string insightName = "insightname";
            NullableResponse<InsightResource> response = await collection.GetIfExistsAsync(insightName);
            InsightResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InsightData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
