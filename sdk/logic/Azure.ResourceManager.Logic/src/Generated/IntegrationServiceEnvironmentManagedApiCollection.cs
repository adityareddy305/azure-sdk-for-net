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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="IntegrationServiceEnvironmentManagedApiResource"/> and their operations.
    /// Each <see cref="IntegrationServiceEnvironmentManagedApiResource"/> in the collection will belong to the same instance of <see cref="IntegrationServiceEnvironmentResource"/>.
    /// To get an <see cref="IntegrationServiceEnvironmentManagedApiCollection"/> instance call the GetIntegrationServiceEnvironmentManagedApis method from an instance of <see cref="IntegrationServiceEnvironmentResource"/>.
    /// </summary>
    public partial class IntegrationServiceEnvironmentManagedApiCollection : ArmCollection, IEnumerable<IntegrationServiceEnvironmentManagedApiResource>, IAsyncEnumerable<IntegrationServiceEnvironmentManagedApiResource>
    {
        private readonly ClientDiagnostics _integrationServiceEnvironmentManagedApiClientDiagnostics;
        private readonly IntegrationServiceEnvironmentManagedApisRestOperations _integrationServiceEnvironmentManagedApiRestClient;

        /// <summary> Initializes a new instance of the <see cref="IntegrationServiceEnvironmentManagedApiCollection"/> class for mocking. </summary>
        protected IntegrationServiceEnvironmentManagedApiCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IntegrationServiceEnvironmentManagedApiCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IntegrationServiceEnvironmentManagedApiCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _integrationServiceEnvironmentManagedApiClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationServiceEnvironmentManagedApiResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IntegrationServiceEnvironmentManagedApiResource.ResourceType, out string integrationServiceEnvironmentManagedApiApiVersion);
            _integrationServiceEnvironmentManagedApiRestClient = new IntegrationServiceEnvironmentManagedApisRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, integrationServiceEnvironmentManagedApiApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IntegrationServiceEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IntegrationServiceEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Puts the integration service environment managed Api.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="data"> The integration service environment managed api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IntegrationServiceEnvironmentManagedApiResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string apiName, IntegrationServiceEnvironmentManagedApiData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiName, nameof(apiName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationServiceEnvironmentManagedApiClientDiagnostics.CreateScope("IntegrationServiceEnvironmentManagedApiCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _integrationServiceEnvironmentManagedApiRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LogicArmOperation<IntegrationServiceEnvironmentManagedApiResource>(new IntegrationServiceEnvironmentManagedApiOperationSource(Client), _integrationServiceEnvironmentManagedApiClientDiagnostics, Pipeline, _integrationServiceEnvironmentManagedApiRestClient.CreatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Puts the integration service environment managed Api.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="data"> The integration service environment managed api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IntegrationServiceEnvironmentManagedApiResource> CreateOrUpdate(WaitUntil waitUntil, string apiName, IntegrationServiceEnvironmentManagedApiData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiName, nameof(apiName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationServiceEnvironmentManagedApiClientDiagnostics.CreateScope("IntegrationServiceEnvironmentManagedApiCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _integrationServiceEnvironmentManagedApiRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, data, cancellationToken);
                var operation = new LogicArmOperation<IntegrationServiceEnvironmentManagedApiResource>(new IntegrationServiceEnvironmentManagedApiOperationSource(Client), _integrationServiceEnvironmentManagedApiClientDiagnostics, Pipeline, _integrationServiceEnvironmentManagedApiRestClient.CreatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the integration service environment managed Api.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiName"/> is null. </exception>
        public virtual async Task<Response<IntegrationServiceEnvironmentManagedApiResource>> GetAsync(string apiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiName, nameof(apiName));

            using var scope = _integrationServiceEnvironmentManagedApiClientDiagnostics.CreateScope("IntegrationServiceEnvironmentManagedApiCollection.Get");
            scope.Start();
            try
            {
                var response = await _integrationServiceEnvironmentManagedApiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationServiceEnvironmentManagedApiResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the integration service environment managed Api.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiName"/> is null. </exception>
        public virtual Response<IntegrationServiceEnvironmentManagedApiResource> Get(string apiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiName, nameof(apiName));

            using var scope = _integrationServiceEnvironmentManagedApiClientDiagnostics.CreateScope("IntegrationServiceEnvironmentManagedApiCollection.Get");
            scope.Start();
            try
            {
                var response = _integrationServiceEnvironmentManagedApiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationServiceEnvironmentManagedApiResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the integration service environment managed Apis.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationServiceEnvironmentManagedApiResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationServiceEnvironmentManagedApiResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationServiceEnvironmentManagedApiRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationServiceEnvironmentManagedApiRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IntegrationServiceEnvironmentManagedApiResource(Client, IntegrationServiceEnvironmentManagedApiData.DeserializeIntegrationServiceEnvironmentManagedApiData(e)), _integrationServiceEnvironmentManagedApiClientDiagnostics, Pipeline, "IntegrationServiceEnvironmentManagedApiCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the integration service environment managed Apis.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationServiceEnvironmentManagedApiResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationServiceEnvironmentManagedApiResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationServiceEnvironmentManagedApiRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationServiceEnvironmentManagedApiRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IntegrationServiceEnvironmentManagedApiResource(Client, IntegrationServiceEnvironmentManagedApiData.DeserializeIntegrationServiceEnvironmentManagedApiData(e)), _integrationServiceEnvironmentManagedApiClientDiagnostics, Pipeline, "IntegrationServiceEnvironmentManagedApiCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string apiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiName, nameof(apiName));

            using var scope = _integrationServiceEnvironmentManagedApiClientDiagnostics.CreateScope("IntegrationServiceEnvironmentManagedApiCollection.Exists");
            scope.Start();
            try
            {
                var response = await _integrationServiceEnvironmentManagedApiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiName"/> is null. </exception>
        public virtual Response<bool> Exists(string apiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiName, nameof(apiName));

            using var scope = _integrationServiceEnvironmentManagedApiClientDiagnostics.CreateScope("IntegrationServiceEnvironmentManagedApiCollection.Exists");
            scope.Start();
            try
            {
                var response = _integrationServiceEnvironmentManagedApiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiName"/> is null. </exception>
        public virtual async Task<NullableResponse<IntegrationServiceEnvironmentManagedApiResource>> GetIfExistsAsync(string apiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiName, nameof(apiName));

            using var scope = _integrationServiceEnvironmentManagedApiClientDiagnostics.CreateScope("IntegrationServiceEnvironmentManagedApiCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _integrationServiceEnvironmentManagedApiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IntegrationServiceEnvironmentManagedApiResource>(response.GetRawResponse());
                return Response.FromValue(new IntegrationServiceEnvironmentManagedApiResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}/managedApis/{apiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironmentManagedApis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationServiceEnvironmentManagedApiResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiName"/> is null. </exception>
        public virtual NullableResponse<IntegrationServiceEnvironmentManagedApiResource> GetIfExists(string apiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiName, nameof(apiName));

            using var scope = _integrationServiceEnvironmentManagedApiClientDiagnostics.CreateScope("IntegrationServiceEnvironmentManagedApiCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _integrationServiceEnvironmentManagedApiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IntegrationServiceEnvironmentManagedApiResource>(response.GetRawResponse());
                return Response.FromValue(new IntegrationServiceEnvironmentManagedApiResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IntegrationServiceEnvironmentManagedApiResource> IEnumerable<IntegrationServiceEnvironmentManagedApiResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IntegrationServiceEnvironmentManagedApiResource> IAsyncEnumerable<IntegrationServiceEnvironmentManagedApiResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
