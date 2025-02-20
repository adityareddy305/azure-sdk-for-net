// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Qumulo.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Qumulo
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Qumulo. </summary>
    public static partial class QumuloExtensions
    {
        private static MockableQumuloArmClient GetMockableQumuloArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableQumuloArmClient(client0));
        }

        private static MockableQumuloResourceGroupResource GetMockableQumuloResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableQumuloResourceGroupResource(client, resource.Id));
        }

        private static MockableQumuloSubscriptionResource GetMockableQumuloSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableQumuloSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="QumuloFileSystemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QumuloFileSystemResource.CreateResourceIdentifier" /> to create a <see cref="QumuloFileSystemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQumuloArmClient.GetQumuloFileSystemResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="QumuloFileSystemResource"/> object. </returns>
        public static QumuloFileSystemResource GetQumuloFileSystemResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQumuloArmClient(client).GetQumuloFileSystemResource(id);
        }

        /// <summary>
        /// Gets a collection of QumuloFileSystemResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQumuloResourceGroupResource.GetQumuloFileSystemResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of QumuloFileSystemResources and their operations over a QumuloFileSystemResource. </returns>
        public static QumuloFileSystemResourceCollection GetQumuloFileSystemResources(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableQumuloResourceGroupResource(resourceGroupResource).GetQumuloFileSystemResources();
        }

        /// <summary>
        /// Get a FileSystemResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-12</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QumuloFileSystemResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQumuloResourceGroupResource.GetQumuloFileSystemResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="fileSystemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<QumuloFileSystemResource>> GetQumuloFileSystemResourceAsync(this ResourceGroupResource resourceGroupResource, string fileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableQumuloResourceGroupResource(resourceGroupResource).GetQumuloFileSystemResourceAsync(fileSystemName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a FileSystemResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-12</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QumuloFileSystemResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQumuloResourceGroupResource.GetQumuloFileSystemResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="fileSystemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<QumuloFileSystemResource> GetQumuloFileSystemResource(this ResourceGroupResource resourceGroupResource, string fileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableQumuloResourceGroupResource(resourceGroupResource).GetQumuloFileSystemResource(fileSystemName, cancellationToken);
        }

        /// <summary>
        /// List FileSystemResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Qumulo.Storage/fileSystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-12</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QumuloFileSystemResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQumuloSubscriptionResource.GetQumuloFileSystemResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="QumuloFileSystemResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<QumuloFileSystemResource> GetQumuloFileSystemResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableQumuloSubscriptionResource(subscriptionResource).GetQumuloFileSystemResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// List FileSystemResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Qumulo.Storage/fileSystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-12</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QumuloFileSystemResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQumuloSubscriptionResource.GetQumuloFileSystemResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="QumuloFileSystemResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<QumuloFileSystemResource> GetQumuloFileSystemResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableQumuloSubscriptionResource(subscriptionResource).GetQumuloFileSystemResources(cancellationToken);
        }
    }
}
