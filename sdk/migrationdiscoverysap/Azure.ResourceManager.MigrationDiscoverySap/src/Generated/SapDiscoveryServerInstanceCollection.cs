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

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    /// <summary>
    /// A class representing a collection of <see cref="SapDiscoveryServerInstanceResource"/> and their operations.
    /// Each <see cref="SapDiscoveryServerInstanceResource"/> in the collection will belong to the same instance of <see cref="SapInstanceResource"/>.
    /// To get a <see cref="SapDiscoveryServerInstanceCollection"/> instance call the GetSapDiscoveryServerInstances method from an instance of <see cref="SapInstanceResource"/>.
    /// </summary>
    public partial class SapDiscoveryServerInstanceCollection : ArmCollection, IEnumerable<SapDiscoveryServerInstanceResource>, IAsyncEnumerable<SapDiscoveryServerInstanceResource>
    {
        private readonly ClientDiagnostics _sapDiscoveryServerInstanceServerInstancesClientDiagnostics;
        private readonly ServerInstancesRestOperations _sapDiscoveryServerInstanceServerInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SapDiscoveryServerInstanceCollection"/> class for mocking. </summary>
        protected SapDiscoveryServerInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SapDiscoveryServerInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SapDiscoveryServerInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sapDiscoveryServerInstanceServerInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MigrationDiscoverySap", SapDiscoveryServerInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SapDiscoveryServerInstanceResource.ResourceType, out string sapDiscoveryServerInstanceServerInstancesApiVersion);
            _sapDiscoveryServerInstanceServerInstancesRestClient = new ServerInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sapDiscoveryServerInstanceServerInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SapInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SapInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the Server Instance resource. &lt;br&gt;&lt;br&gt;;This will be used by service only. PUT operation on this resource by end user will return a Bad Request error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SapDiscoveryServerInstanceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverInstanceName, SapDiscoveryServerInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverInstanceName, nameof(serverInstanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapDiscoveryServerInstanceServerInstancesClientDiagnostics.CreateScope("SapDiscoveryServerInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sapDiscoveryServerInstanceServerInstancesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MigrationDiscoverySapArmOperation<SapDiscoveryServerInstanceResource>(new SapDiscoveryServerInstanceOperationSource(Client), _sapDiscoveryServerInstanceServerInstancesClientDiagnostics, Pipeline, _sapDiscoveryServerInstanceServerInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates the Server Instance resource. &lt;br&gt;&lt;br&gt;;This will be used by service only. PUT operation on this resource by end user will return a Bad Request error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SapDiscoveryServerInstanceResource> CreateOrUpdate(WaitUntil waitUntil, string serverInstanceName, SapDiscoveryServerInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverInstanceName, nameof(serverInstanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapDiscoveryServerInstanceServerInstancesClientDiagnostics.CreateScope("SapDiscoveryServerInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sapDiscoveryServerInstanceServerInstancesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, data, cancellationToken);
                var operation = new MigrationDiscoverySapArmOperation<SapDiscoveryServerInstanceResource>(new SapDiscoveryServerInstanceOperationSource(Client), _sapDiscoveryServerInstanceServerInstancesClientDiagnostics, Pipeline, _sapDiscoveryServerInstanceServerInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the Server Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual async Task<Response<SapDiscoveryServerInstanceResource>> GetAsync(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverInstanceName, nameof(serverInstanceName));

            using var scope = _sapDiscoveryServerInstanceServerInstancesClientDiagnostics.CreateScope("SapDiscoveryServerInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _sapDiscoveryServerInstanceServerInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapDiscoveryServerInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Server Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual Response<SapDiscoveryServerInstanceResource> Get(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverInstanceName, nameof(serverInstanceName));

            using var scope = _sapDiscoveryServerInstanceServerInstancesClientDiagnostics.CreateScope("SapDiscoveryServerInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _sapDiscoveryServerInstanceServerInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapDiscoveryServerInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Server Instance resources for the given SAP Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_ListBySapInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SapDiscoveryServerInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SapDiscoveryServerInstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sapDiscoveryServerInstanceServerInstancesRestClient.CreateListBySapInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sapDiscoveryServerInstanceServerInstancesRestClient.CreateListBySapInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SapDiscoveryServerInstanceResource(Client, SapDiscoveryServerInstanceData.DeserializeSapDiscoveryServerInstanceData(e)), _sapDiscoveryServerInstanceServerInstancesClientDiagnostics, Pipeline, "SapDiscoveryServerInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Server Instance resources for the given SAP Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_ListBySapInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SapDiscoveryServerInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SapDiscoveryServerInstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sapDiscoveryServerInstanceServerInstancesRestClient.CreateListBySapInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sapDiscoveryServerInstanceServerInstancesRestClient.CreateListBySapInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SapDiscoveryServerInstanceResource(Client, SapDiscoveryServerInstanceData.DeserializeSapDiscoveryServerInstanceData(e)), _sapDiscoveryServerInstanceServerInstancesClientDiagnostics, Pipeline, "SapDiscoveryServerInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverInstanceName, nameof(serverInstanceName));

            using var scope = _sapDiscoveryServerInstanceServerInstancesClientDiagnostics.CreateScope("SapDiscoveryServerInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sapDiscoveryServerInstanceServerInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverInstanceName, nameof(serverInstanceName));

            using var scope = _sapDiscoveryServerInstanceServerInstancesClientDiagnostics.CreateScope("SapDiscoveryServerInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _sapDiscoveryServerInstanceServerInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual async Task<NullableResponse<SapDiscoveryServerInstanceResource>> GetIfExistsAsync(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverInstanceName, nameof(serverInstanceName));

            using var scope = _sapDiscoveryServerInstanceServerInstancesClientDiagnostics.CreateScope("SapDiscoveryServerInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sapDiscoveryServerInstanceServerInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SapDiscoveryServerInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new SapDiscoveryServerInstanceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoveryServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual NullableResponse<SapDiscoveryServerInstanceResource> GetIfExists(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverInstanceName, nameof(serverInstanceName));

            using var scope = _sapDiscoveryServerInstanceServerInstancesClientDiagnostics.CreateScope("SapDiscoveryServerInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sapDiscoveryServerInstanceServerInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SapDiscoveryServerInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new SapDiscoveryServerInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SapDiscoveryServerInstanceResource> IEnumerable<SapDiscoveryServerInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SapDiscoveryServerInstanceResource> IAsyncEnumerable<SapDiscoveryServerInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
