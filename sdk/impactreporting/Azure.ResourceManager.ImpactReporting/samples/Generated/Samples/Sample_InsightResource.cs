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
    public partial class Sample_InsightResource
    {
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

            // this example assumes you already have this InsightResource created on azure
            // for more information of creating InsightResource, please refer to the document of InsightResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid";
            string insightName = "insight1";
            ResourceIdentifier insightResourceId = InsightResource.CreateResourceIdentifier(subscriptionId, workloadImpactName, insightName);
            InsightResource insight = client.GetInsightResource(insightResourceId);

            // invoke the operation
            InsightResource result = await insight.GetAsync();

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

            // this example assumes you already have this InsightResource created on azure
            // for more information of creating InsightResource, please refer to the document of InsightResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactId";
            string insightName = "HPCUASucceeded";
            ResourceIdentifier insightResourceId = InsightResource.CreateResourceIdentifier(subscriptionId, workloadImpactName, insightName);
            InsightResource insight = client.GetInsightResource(insightResourceId);

            // invoke the operation
            InsightResource result = await insight.GetAsync();

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

            // this example assumes you already have this InsightResource created on azure
            // for more information of creating InsightResource, please refer to the document of InsightResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid";
            string insightName = "insightname";
            ResourceIdentifier insightResourceId = InsightResource.CreateResourceIdentifier(subscriptionId, workloadImpactName, insightName);
            InsightResource insight = client.GetInsightResource(insightResourceId);

            // invoke the operation
            InsightResource result = await insight.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InsightData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnInsight()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Delete.json
            // this example is just showing the usage of "Insight_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InsightResource created on azure
            // for more information of creating InsightResource, please refer to the document of InsightResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid22";
            string insightName = "insightId12";
            ResourceIdentifier insightResourceId = InsightResource.CreateResourceIdentifier(subscriptionId, workloadImpactName, insightName);
            InsightResource insight = client.GetInsightResource(insightResourceId);

            // invoke the operation
            await insight.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatingAnInsight()
        {
            // Generated from example definition: 2024-05-01-preview/Insights_Create.json
            // this example is just showing the usage of "Insight_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InsightResource created on azure
            // for more information of creating InsightResource, please refer to the document of InsightResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impactid22";
            string insightName = "insightId12";
            ResourceIdentifier insightResourceId = InsightResource.CreateResourceIdentifier(subscriptionId, workloadImpactName, insightName);
            InsightResource insight = client.GetInsightResource(insightResourceId);

            // invoke the operation
            InsightData data = new InsightData
            {
                Properties = new InsightProperties("repair", new Content("Impact Has been correlated to an outage", "At 2018-11-08T00:00:00Z UTC, your services dependent on these resources <link href=”…”>VM1</link> may have experienced an issue. <br/><div>We have identified an outage that affected these resources(s). You can look at outage information on <link href=\"https:// portal.azure.com/#view/Microsoft_Azure_Health/AzureHealthBrowseBlade/~/serviceIssues/trackingId/NL2W-VCZ\">NL2W-VCZ</link> link.<div>"), "00000000-0000-0000-0000-000000000000", new ImpactDetails("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resource-rg/providers/Microsoft.Sql/sqlserver/dbservername", DateTimeOffset.Parse("2023-06-15T01:00:00.009223Z"), "/subscriptions/00000000-0000-0000-0000-000000000000/providers/microsoft.Impact/workloadImpacts/impactid22"))
                {
                    Status = "resolved",
                    EventOn = DateTimeOffset.Parse("2023-06-15T04:00:00.009223Z"),
                },
            };
            ArmOperation<InsightResource> lro = await insight.UpdateAsync(WaitUntil.Completed, data);
            InsightResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InsightData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
