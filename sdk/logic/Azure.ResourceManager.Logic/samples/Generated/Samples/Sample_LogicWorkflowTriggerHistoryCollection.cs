// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_LogicWorkflowTriggerHistoryCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAWorkflowTriggerHistory()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/WorkflowTriggerHistories_Get.json
            // this example is just showing the usage of "WorkflowTriggerHistories_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogicWorkflowTriggerResource created on azure
            // for more information of creating LogicWorkflowTriggerResource, please refer to the document of LogicWorkflowTriggerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string workflowName = "testWorkflowName";
            string triggerName = "testTriggerName";
            ResourceIdentifier logicWorkflowTriggerResourceId = LogicWorkflowTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workflowName, triggerName);
            LogicWorkflowTriggerResource logicWorkflowTrigger = client.GetLogicWorkflowTriggerResource(logicWorkflowTriggerResourceId);

            // get the collection of this LogicWorkflowTriggerHistoryResource
            LogicWorkflowTriggerHistoryCollection collection = logicWorkflowTrigger.GetLogicWorkflowTriggerHistories();

            // invoke the operation
            string historyName = "08586676746934337772206998657CU22";
            LogicWorkflowTriggerHistoryResource result = await collection.GetAsync(historyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LogicWorkflowTriggerHistoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAWorkflowTriggerHistory()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/WorkflowTriggerHistories_List.json
            // this example is just showing the usage of "WorkflowTriggerHistories_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogicWorkflowTriggerResource created on azure
            // for more information of creating LogicWorkflowTriggerResource, please refer to the document of LogicWorkflowTriggerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string workflowName = "testWorkflowName";
            string triggerName = "testTriggerName";
            ResourceIdentifier logicWorkflowTriggerResourceId = LogicWorkflowTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workflowName, triggerName);
            LogicWorkflowTriggerResource logicWorkflowTrigger = client.GetLogicWorkflowTriggerResource(logicWorkflowTriggerResourceId);

            // get the collection of this LogicWorkflowTriggerHistoryResource
            LogicWorkflowTriggerHistoryCollection collection = logicWorkflowTrigger.GetLogicWorkflowTriggerHistories();

            // invoke the operation and iterate over the result
            await foreach (LogicWorkflowTriggerHistoryResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LogicWorkflowTriggerHistoryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAWorkflowTriggerHistory()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/WorkflowTriggerHistories_Get.json
            // this example is just showing the usage of "WorkflowTriggerHistories_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogicWorkflowTriggerResource created on azure
            // for more information of creating LogicWorkflowTriggerResource, please refer to the document of LogicWorkflowTriggerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string workflowName = "testWorkflowName";
            string triggerName = "testTriggerName";
            ResourceIdentifier logicWorkflowTriggerResourceId = LogicWorkflowTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workflowName, triggerName);
            LogicWorkflowTriggerResource logicWorkflowTrigger = client.GetLogicWorkflowTriggerResource(logicWorkflowTriggerResourceId);

            // get the collection of this LogicWorkflowTriggerHistoryResource
            LogicWorkflowTriggerHistoryCollection collection = logicWorkflowTrigger.GetLogicWorkflowTriggerHistories();

            // invoke the operation
            string historyName = "08586676746934337772206998657CU22";
            bool result = await collection.ExistsAsync(historyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAWorkflowTriggerHistory()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/WorkflowTriggerHistories_Get.json
            // this example is just showing the usage of "WorkflowTriggerHistories_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogicWorkflowTriggerResource created on azure
            // for more information of creating LogicWorkflowTriggerResource, please refer to the document of LogicWorkflowTriggerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string workflowName = "testWorkflowName";
            string triggerName = "testTriggerName";
            ResourceIdentifier logicWorkflowTriggerResourceId = LogicWorkflowTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workflowName, triggerName);
            LogicWorkflowTriggerResource logicWorkflowTrigger = client.GetLogicWorkflowTriggerResource(logicWorkflowTriggerResourceId);

            // get the collection of this LogicWorkflowTriggerHistoryResource
            LogicWorkflowTriggerHistoryCollection collection = logicWorkflowTrigger.GetLogicWorkflowTriggerHistories();

            // invoke the operation
            string historyName = "08586676746934337772206998657CU22";
            NullableResponse<LogicWorkflowTriggerHistoryResource> response = await collection.GetIfExistsAsync(historyName);
            LogicWorkflowTriggerHistoryResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LogicWorkflowTriggerHistoryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
