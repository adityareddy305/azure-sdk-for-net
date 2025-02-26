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
    public partial class Sample_WorkloadImpactResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWorkloadImpactResourceByNameExample()
        {
            // Generated from example definition: 2024-05-01-preview/WorkloadImpact_Get.json
            // this example is just showing the usage of "WorkloadImpact_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impact-001";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // invoke the operation
            WorkloadImpactResource result = await workloadImpact.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadImpactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteWorkloadImpactResourceByNameExample()
        {
            // Generated from example definition: 2024-05-01-preview/WorkloadImpact_Delete.json
            // this example is just showing the usage of "WorkloadImpact_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impact-001";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // invoke the operation
            await workloadImpact.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ReportingArmOperationFailure()
        {
            // Generated from example definition: 2024-05-01-preview/WorkloadArmOperation_create.json
            // this example is just showing the usage of "WorkloadImpact_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impact-002";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // invoke the operation
            WorkloadImpactData data = new WorkloadImpactData
            {
                Properties = new WorkloadImpactProperties(DateTimeOffset.Parse("2022-06-15T05:59:46.6517821Z"), "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resource-rg/providers/Microsoft.Sql/sqlserver/dbservercontext", "ArmOperation")
                {
                    ImpactDescription = "deletion of resource failed",
                    ArmCorrelationIds = { "00000000-0000-0000-0000-000000000000" },
                    Workload = new Workload
                    {
                        Context = "webapp/scenario1",
                        Toolset = Toolset.Other,
                    },
                    ClientIncidentDetails = new ClientIncidentDetails
                    {
                        ClientIncidentId = "AA123",
                        ClientIncidentSource = IncidentSource.Jira,
                    },
                },
            };
            ArmOperation<WorkloadImpactResource> lro = await workloadImpact.UpdateAsync(WaitUntil.Completed, data);
            WorkloadImpactResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadImpactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ReportingAvailabilityRelatedImpact()
        {
            // Generated from example definition: 2024-05-01-preview/WorkloadAvailability_Create.json
            // this example is just showing the usage of "WorkloadImpact_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impact-002";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // invoke the operation
            WorkloadImpactData data = new WorkloadImpactData
            {
                Properties = new WorkloadImpactProperties(DateTimeOffset.Parse("2022-06-15T05:59:46.6517821Z"), "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resource-rg/providers/Microsoft.Sql/sqlserver/dbservercontext", "Availability")
                {
                    ImpactDescription = "read calls failed",
                    Workload = new Workload
                    {
                        Context = "webapp/scenario1",
                        Toolset = Toolset.Other,
                    },
                    ClientIncidentDetails = new ClientIncidentDetails
                    {
                        ClientIncidentId = "AA123",
                        ClientIncidentSource = IncidentSource.Jira,
                    },
                },
            };
            ArmOperation<WorkloadImpactResource> lro = await workloadImpact.UpdateAsync(WaitUntil.Completed, data);
            WorkloadImpactResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadImpactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ReportingAConnectivityImpact()
        {
            // Generated from example definition: 2024-05-01-preview/WorkloadConnectivityImpact_Create.json
            // this example is just showing the usage of "WorkloadImpact_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impact-001";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // invoke the operation
            WorkloadImpactData data = new WorkloadImpactData
            {
                Properties = new WorkloadImpactProperties(DateTimeOffset.Parse("2022-06-15T05:59:46.6517821Z"), "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resource-rg/providers/Microsoft.Sql/sqlserver/dbservercontext", "Resource.Connectivity")
                {
                    ImpactDescription = "conection failure",
                    Connectivity = new Connectivity
                    {
                        Protocol = Protocol.TCP,
                        Port = 1443,
                        SourceAzureResourceId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resourceSub/providers/Microsoft.compute/virtualmachines/vm1",
                        TargetAzureResourceId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resourceSub/providers/Microsoft.compute/virtualmachines/vm2",
                    },
                    Workload = new Workload
                    {
                        Context = "webapp/scenario1",
                        Toolset = Toolset.Other,
                    },
                    ClientIncidentDetails = new ClientIncidentDetails
                    {
                        ClientIncidentId = "AA123",
                        ClientIncidentSource = IncidentSource.Jira,
                    },
                },
            };
            ArmOperation<WorkloadImpactResource> lro = await workloadImpact.UpdateAsync(WaitUntil.Completed, data);
            WorkloadImpactResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadImpactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ReportingPerformanceRelatedImpact()
        {
            // Generated from example definition: 2024-05-01-preview/WorkloadPerformance_Create.json
            // this example is just showing the usage of "WorkloadImpact_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadImpactResource created on azure
            // for more information of creating WorkloadImpactResource, please refer to the document of WorkloadImpactResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string workloadImpactName = "impact-002";
            ResourceIdentifier workloadImpactResourceId = WorkloadImpactResource.CreateResourceIdentifier(subscriptionId, workloadImpactName);
            WorkloadImpactResource workloadImpact = client.GetWorkloadImpactResource(workloadImpactResourceId);

            // invoke the operation
            WorkloadImpactData data = new WorkloadImpactData
            {
                Properties = new WorkloadImpactProperties(DateTimeOffset.Parse("2022-06-15T05:59:46.6517821Z"), "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resource-rg/providers/Microsoft.Sql/sqlserver/dbservercontext", "Resource.Performance")
                {
                    ImpactDescription = "high cpu utilization",
                    Performance = {new Performance
{
MetricName = "CPU",
Expected = 60,
Actual = 90,
}},
                    Workload = new Workload
                    {
                        Context = "webapp/scenario1",
                        Toolset = Toolset.Other,
                    },
                    ClientIncidentDetails = new ClientIncidentDetails
                    {
                        ClientIncidentId = "AA123",
                        ClientIncidentSource = IncidentSource.Jira,
                    },
                },
            };
            ArmOperation<WorkloadImpactResource> lro = await workloadImpact.UpdateAsync(WaitUntil.Completed, data);
            WorkloadImpactResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadImpactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
