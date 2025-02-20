// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.DefenderEasm.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DefenderEasm
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DefenderEasm. </summary>
    public static partial class DefenderEasmExtensions
    {
        private static MockableDefenderEasmArmClient GetMockableDefenderEasmArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDefenderEasmArmClient(client0));
        }

        private static MockableDefenderEasmResourceGroupResource GetMockableDefenderEasmResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDefenderEasmResourceGroupResource(client, resource.Id));
        }

        private static MockableDefenderEasmSubscriptionResource GetMockableDefenderEasmSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDefenderEasmSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="EasmWorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EasmWorkspaceResource.CreateResourceIdentifier" /> to create an <see cref="EasmWorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDefenderEasmArmClient.GetEasmWorkspaceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="EasmWorkspaceResource"/> object. </returns>
        public static EasmWorkspaceResource GetEasmWorkspaceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDefenderEasmArmClient(client).GetEasmWorkspaceResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EasmLabelResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EasmLabelResource.CreateResourceIdentifier" /> to create an <see cref="EasmLabelResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDefenderEasmArmClient.GetEasmLabelResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="EasmLabelResource"/> object. </returns>
        public static EasmLabelResource GetEasmLabelResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDefenderEasmArmClient(client).GetEasmLabelResource(id);
        }

        /// <summary>
        /// Gets a collection of EasmWorkspaceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDefenderEasmResourceGroupResource.GetEasmWorkspaces()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of EasmWorkspaceResources and their operations over a EasmWorkspaceResource. </returns>
        public static EasmWorkspaceCollection GetEasmWorkspaces(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDefenderEasmResourceGroupResource(resourceGroupResource).GetEasmWorkspaces();
        }

        /// <summary>
        /// Returns a workspace with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDefenderEasmResourceGroupResource.GetEasmWorkspaceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of the Workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EasmWorkspaceResource>> GetEasmWorkspaceAsync(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableDefenderEasmResourceGroupResource(resourceGroupResource).GetEasmWorkspaceAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a workspace with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDefenderEasmResourceGroupResource.GetEasmWorkspace(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of the Workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<EasmWorkspaceResource> GetEasmWorkspace(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDefenderEasmResourceGroupResource(resourceGroupResource).GetEasmWorkspace(workspaceName, cancellationToken);
        }

        /// <summary>
        /// Returns a list of workspaces under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Easm/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDefenderEasmSubscriptionResource.GetEasmWorkspaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="EasmWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EasmWorkspaceResource> GetEasmWorkspacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDefenderEasmSubscriptionResource(subscriptionResource).GetEasmWorkspacesAsync(cancellationToken);
        }

        /// <summary>
        /// Returns a list of workspaces under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Easm/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDefenderEasmSubscriptionResource.GetEasmWorkspaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="EasmWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EasmWorkspaceResource> GetEasmWorkspaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDefenderEasmSubscriptionResource(subscriptionResource).GetEasmWorkspaces(cancellationToken);
        }
    }
}
