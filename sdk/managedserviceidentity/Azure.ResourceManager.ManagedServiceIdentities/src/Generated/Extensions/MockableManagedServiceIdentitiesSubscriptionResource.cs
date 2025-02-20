// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ManagedServiceIdentities.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableManagedServiceIdentitiesSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _userAssignedIdentityClientDiagnostics;
        private UserAssignedIdentitiesRestOperations _userAssignedIdentityRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableManagedServiceIdentitiesSubscriptionResource"/> class for mocking. </summary>
        protected MockableManagedServiceIdentitiesSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableManagedServiceIdentitiesSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableManagedServiceIdentitiesSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics UserAssignedIdentityClientDiagnostics => _userAssignedIdentityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ManagedServiceIdentities", UserAssignedIdentityResource.ResourceType.Namespace, Diagnostics);
        private UserAssignedIdentitiesRestOperations UserAssignedIdentityRestClient => _userAssignedIdentityRestClient ??= new UserAssignedIdentitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(UserAssignedIdentityResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the userAssignedIdentities available under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedIdentity/userAssignedIdentities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="UserAssignedIdentityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<UserAssignedIdentityResource> GetUserAssignedIdentitiesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UserAssignedIdentityRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UserAssignedIdentityRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new UserAssignedIdentityResource(Client, UserAssignedIdentityData.DeserializeUserAssignedIdentityData(e)), UserAssignedIdentityClientDiagnostics, Pipeline, "MockableManagedServiceIdentitiesSubscriptionResource.GetUserAssignedIdentities", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the userAssignedIdentities available under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedIdentity/userAssignedIdentities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserAssignedIdentities_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="UserAssignedIdentityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<UserAssignedIdentityResource> GetUserAssignedIdentities(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UserAssignedIdentityRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UserAssignedIdentityRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new UserAssignedIdentityResource(Client, UserAssignedIdentityData.DeserializeUserAssignedIdentityData(e)), UserAssignedIdentityClientDiagnostics, Pipeline, "MockableManagedServiceIdentitiesSubscriptionResource.GetUserAssignedIdentities", "value", "nextLink", cancellationToken);
        }
    }
}
