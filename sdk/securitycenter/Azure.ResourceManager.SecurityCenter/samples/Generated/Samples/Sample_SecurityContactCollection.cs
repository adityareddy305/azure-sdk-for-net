// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_SecurityContactCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateSecurityContactData()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2020-01-01-preview/examples/SecurityContacts/CreateSecurityContact_example.json
            // this example is just showing the usage of "SecurityContacts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityContactResource
            SecurityContactCollection collection = subscriptionResource.GetSecurityContacts();

            // invoke the operation
            string securityContactName = "default";
            SecurityContactData data = new SecurityContactData
            {
                Emails = "john@contoso.com;jane@contoso.com",
                Phone = "(214)275-4038",
                AlertNotifications = new SecurityContactPropertiesAlertNotifications
                {
                    State = SecurityAlertNotificationState.On,
                    MinimalSeverity = SecurityAlertMinimalSeverity.Low,
                },
                NotificationsByRole = new SecurityContactPropertiesNotificationsByRole
                {
                    State = SecurityAlertNotificationByRoleState.On,
                    Roles = { SecurityAlertReceivingRole.Owner },
                },
            };
            ArmOperation<SecurityContactResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityContactName, data);
            SecurityContactResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityContactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetASecurityContact()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2020-01-01-preview/examples/SecurityContacts/GetSecurityContact_example.json
            // this example is just showing the usage of "SecurityContacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityContactResource
            SecurityContactCollection collection = subscriptionResource.GetSecurityContacts();

            // invoke the operation
            string securityContactName = "default";
            SecurityContactResource result = await collection.GetAsync(securityContactName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityContactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListSecurityContactData()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2020-01-01-preview/examples/SecurityContacts/GetSecurityContactsSubscription_example.json
            // this example is just showing the usage of "SecurityContacts_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityContactResource
            SecurityContactCollection collection = subscriptionResource.GetSecurityContacts();

            // invoke the operation and iterate over the result
            await foreach (SecurityContactResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityContactData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetASecurityContact()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2020-01-01-preview/examples/SecurityContacts/GetSecurityContact_example.json
            // this example is just showing the usage of "SecurityContacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityContactResource
            SecurityContactCollection collection = subscriptionResource.GetSecurityContacts();

            // invoke the operation
            string securityContactName = "default";
            bool result = await collection.ExistsAsync(securityContactName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetASecurityContact()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2020-01-01-preview/examples/SecurityContacts/GetSecurityContact_example.json
            // this example is just showing the usage of "SecurityContacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityContactResource
            SecurityContactCollection collection = subscriptionResource.GetSecurityContacts();

            // invoke the operation
            string securityContactName = "default";
            NullableResponse<SecurityContactResource> response = await collection.GetIfExistsAsync(securityContactName);
            SecurityContactResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityContactData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
