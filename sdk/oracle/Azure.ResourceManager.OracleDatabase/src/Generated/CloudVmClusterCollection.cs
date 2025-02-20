// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A class representing a collection of <see cref="CloudVmClusterResource"/> and their operations.
    /// Each <see cref="CloudVmClusterResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="CloudVmClusterCollection"/> instance call the GetCloudVmClusters method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class CloudVmClusterCollection : ArmCollection, IEnumerable<CloudVmClusterResource>, IAsyncEnumerable<CloudVmClusterResource>
    {
        private readonly ClientDiagnostics _cloudVmClusterClientDiagnostics;
        private readonly CloudVmClustersRestOperations _cloudVmClusterRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudVmClusterCollection"/> class for mocking. </summary>
        protected CloudVmClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudVmClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CloudVmClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudVmClusterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", CloudVmClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudVmClusterResource.ResourceType, out string cloudVmClusterApiVersion);
            _cloudVmClusterRestClient = new CloudVmClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudVmClusterApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a CloudVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudvmclustername"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CloudVmClusterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cloudvmclustername, CloudVmClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cloudVmClusterClientDiagnostics.CreateScope("CloudVmClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, data, cancellationToken).ConfigureAwait(false);
                var operation = new OracleDatabaseArmOperation<CloudVmClusterResource>(new CloudVmClusterOperationSource(Client), _cloudVmClusterClientDiagnostics, Pipeline, _cloudVmClusterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a CloudVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudvmclustername"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CloudVmClusterResource> CreateOrUpdate(WaitUntil waitUntil, string cloudvmclustername, CloudVmClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cloudVmClusterClientDiagnostics.CreateScope("CloudVmClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cloudVmClusterRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, data, cancellationToken);
                var operation = new OracleDatabaseArmOperation<CloudVmClusterResource>(new CloudVmClusterOperationSource(Client), _cloudVmClusterClientDiagnostics, Pipeline, _cloudVmClusterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a CloudVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudvmclustername"/> is null. </exception>
        public virtual async Task<Response<CloudVmClusterResource>> GetAsync(string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var scope = _cloudVmClusterClientDiagnostics.CreateScope("CloudVmClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a CloudVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudvmclustername"/> is null. </exception>
        public virtual Response<CloudVmClusterResource> Get(string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var scope = _cloudVmClusterClientDiagnostics.CreateScope("CloudVmClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudVmClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List CloudVmCluster resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudVmClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudVmClusterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudVmClusterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudVmClusterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CloudVmClusterResource(Client, CloudVmClusterData.DeserializeCloudVmClusterData(e)), _cloudVmClusterClientDiagnostics, Pipeline, "CloudVmClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List CloudVmCluster resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudVmClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudVmClusterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudVmClusterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudVmClusterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CloudVmClusterResource(Client, CloudVmClusterData.DeserializeCloudVmClusterData(e)), _cloudVmClusterClientDiagnostics, Pipeline, "CloudVmClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudvmclustername"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var scope = _cloudVmClusterClientDiagnostics.CreateScope("CloudVmClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudvmclustername"/> is null. </exception>
        public virtual Response<bool> Exists(string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var scope = _cloudVmClusterClientDiagnostics.CreateScope("CloudVmClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudVmClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudvmclustername"/> is null. </exception>
        public virtual async Task<NullableResponse<CloudVmClusterResource>> GetIfExistsAsync(string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var scope = _cloudVmClusterClientDiagnostics.CreateScope("CloudVmClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CloudVmClusterResource>(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudVmClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudvmclustername"/> is null. </exception>
        public virtual NullableResponse<CloudVmClusterResource> GetIfExists(string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var scope = _cloudVmClusterClientDiagnostics.CreateScope("CloudVmClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudVmClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudvmclustername, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CloudVmClusterResource>(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudVmClusterResource> IEnumerable<CloudVmClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudVmClusterResource> IAsyncEnumerable<CloudVmClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
