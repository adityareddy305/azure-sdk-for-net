// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.HealthDataAIServices.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HealthDataAIServices
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HealthDataAIServices. </summary>
    public static partial class HealthDataAIServicesExtensions
    {
        private static MockableHealthDataAIServicesArmClient GetMockableHealthDataAIServicesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableHealthDataAIServicesArmClient(client0));
        }

        private static MockableHealthDataAIServicesResourceGroupResource GetMockableHealthDataAIServicesResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHealthDataAIServicesResourceGroupResource(client, resource.Id));
        }

        private static MockableHealthDataAIServicesSubscriptionResource GetMockableHealthDataAIServicesSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHealthDataAIServicesSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeidServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeidServiceResource.CreateResourceIdentifier" /> to create a <see cref="DeidServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthDataAIServicesArmClient.GetDeidServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DeidServiceResource"/> object. </returns>
        public static DeidServiceResource GetDeidServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthDataAIServicesArmClient(client).GetDeidServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthDataAIServicesPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthDataAIServicesPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HealthDataAIServicesPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthDataAIServicesArmClient.GetHealthDataAIServicesPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthDataAIServicesPrivateEndpointConnectionResource"/> object. </returns>
        public static HealthDataAIServicesPrivateEndpointConnectionResource GetHealthDataAIServicesPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthDataAIServicesArmClient(client).GetHealthDataAIServicesPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets a collection of DeidServiceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthDataAIServicesResourceGroupResource.GetDeidServices()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DeidServiceResources and their operations over a DeidServiceResource. </returns>
        public static DeidServiceCollection GetDeidServices(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHealthDataAIServicesResourceGroupResource(resourceGroupResource).GetDeidServices();
        }

        /// <summary>
        /// Get a DeidService
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthDataAIServicesResourceGroupResource.GetDeidServiceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="deidServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DeidServiceResource>> GetDeidServiceAsync(this ResourceGroupResource resourceGroupResource, string deidServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableHealthDataAIServicesResourceGroupResource(resourceGroupResource).GetDeidServiceAsync(deidServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a DeidService
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthDataAIServicesResourceGroupResource.GetDeidService(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="deidServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DeidServiceResource> GetDeidService(this ResourceGroupResource resourceGroupResource, string deidServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHealthDataAIServicesResourceGroupResource(resourceGroupResource).GetDeidService(deidServiceName, cancellationToken);
        }

        /// <summary>
        /// List DeidService resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthDataAIServices/deidServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthDataAIServicesSubscriptionResource.GetDeidServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DeidServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeidServiceResource> GetDeidServicesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHealthDataAIServicesSubscriptionResource(subscriptionResource).GetDeidServicesAsync(cancellationToken);
        }

        /// <summary>
        /// List DeidService resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthDataAIServices/deidServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthDataAIServicesSubscriptionResource.GetDeidServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DeidServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeidServiceResource> GetDeidServices(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHealthDataAIServicesSubscriptionResource(subscriptionResource).GetDeidServices(cancellationToken);
        }
    }
}
