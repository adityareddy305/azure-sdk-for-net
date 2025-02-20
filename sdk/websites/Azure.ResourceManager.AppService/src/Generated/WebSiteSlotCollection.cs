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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSiteSlotResource"/> and their operations.
    /// Each <see cref="WebSiteSlotResource"/> in the collection will belong to the same instance of <see cref="WebSiteResource"/>.
    /// To get a <see cref="WebSiteSlotCollection"/> instance call the GetWebSiteSlots method from an instance of <see cref="WebSiteResource"/>.
    /// </summary>
    public partial class WebSiteSlotCollection : ArmCollection, IEnumerable<WebSiteSlotResource>, IAsyncEnumerable<WebSiteSlotResource>
    {
        private readonly ClientDiagnostics _webSiteSlotWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotCollection"/> class for mocking. </summary>
        protected WebSiteSlotCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteSlotCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteSlotResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteSlotResource.ResourceType, out string webSiteSlotWebAppsApiVersion);
            _webSiteSlotWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a new web, mobile, or API app in an existing resource group, or updates an existing app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="slot"> Name of the deployment slot to create or update. By default, this API attempts to create or modify the production slot. </param>
        /// <param name="data"> A JSON representation of the app properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="slot"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="slot"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebSiteSlotResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string slot, WebSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(slot, nameof(slot));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSlotWebAppsClientDiagnostics.CreateScope("WebSiteSlotCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webSiteSlotWebAppsRestClient.CreateOrUpdateSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<WebSiteSlotResource>(new WebSiteSlotOperationSource(Client), _webSiteSlotWebAppsClientDiagnostics, Pipeline, _webSiteSlotWebAppsRestClient.CreateCreateOrUpdateSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Creates a new web, mobile, or API app in an existing resource group, or updates an existing app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="slot"> Name of the deployment slot to create or update. By default, this API attempts to create or modify the production slot. </param>
        /// <param name="data"> A JSON representation of the app properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="slot"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="slot"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebSiteSlotResource> CreateOrUpdate(WaitUntil waitUntil, string slot, WebSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(slot, nameof(slot));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSlotWebAppsClientDiagnostics.CreateScope("WebSiteSlotCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webSiteSlotWebAppsRestClient.CreateOrUpdateSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, data, cancellationToken);
                var operation = new AppServiceArmOperation<WebSiteSlotResource>(new WebSiteSlotOperationSource(Client), _webSiteSlotWebAppsClientDiagnostics, Pipeline, _webSiteSlotWebAppsRestClient.CreateCreateOrUpdateSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Gets the details of a web, mobile, or API app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="slot"> Name of the deployment slot. By default, this API returns the production slot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="slot"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="slot"/> is null. </exception>
        public virtual async Task<Response<WebSiteSlotResource>> GetAsync(string slot, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(slot, nameof(slot));

            using var scope = _webSiteSlotWebAppsClientDiagnostics.CreateScope("WebSiteSlotCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotWebAppsRestClient.GetSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of a web, mobile, or API app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="slot"> Name of the deployment slot. By default, this API returns the production slot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="slot"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="slot"/> is null. </exception>
        public virtual Response<WebSiteSlotResource> Get(string slot, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(slot, nameof(slot));

            using var scope = _webSiteSlotWebAppsClientDiagnostics.CreateScope("WebSiteSlotCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotWebAppsRestClient.GetSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an app's deployment slots.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListSlots</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteSlotResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteSlotResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotWebAppsRestClient.CreateListSlotsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotWebAppsRestClient.CreateListSlotsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotResource(Client, WebSiteData.DeserializeWebSiteData(e)), _webSiteSlotWebAppsClientDiagnostics, Pipeline, "WebSiteSlotCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets an app's deployment slots.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListSlots</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteSlotResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteSlotResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotWebAppsRestClient.CreateListSlotsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotWebAppsRestClient.CreateListSlotsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotResource(Client, WebSiteData.DeserializeWebSiteData(e)), _webSiteSlotWebAppsClientDiagnostics, Pipeline, "WebSiteSlotCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="slot"> Name of the deployment slot. By default, this API returns the production slot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="slot"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="slot"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string slot, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(slot, nameof(slot));

            using var scope = _webSiteSlotWebAppsClientDiagnostics.CreateScope("WebSiteSlotCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotWebAppsRestClient.GetSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="slot"> Name of the deployment slot. By default, this API returns the production slot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="slot"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="slot"/> is null. </exception>
        public virtual Response<bool> Exists(string slot, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(slot, nameof(slot));

            using var scope = _webSiteSlotWebAppsClientDiagnostics.CreateScope("WebSiteSlotCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteSlotWebAppsRestClient.GetSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="slot"> Name of the deployment slot. By default, this API returns the production slot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="slot"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="slot"/> is null. </exception>
        public virtual async Task<NullableResponse<WebSiteSlotResource>> GetIfExistsAsync(string slot, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(slot, nameof(slot));

            using var scope = _webSiteSlotWebAppsClientDiagnostics.CreateScope("WebSiteSlotCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotWebAppsRestClient.GetSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="slot"> Name of the deployment slot. By default, this API returns the production slot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="slot"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="slot"/> is null. </exception>
        public virtual NullableResponse<WebSiteSlotResource> GetIfExists(string slot, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(slot, nameof(slot));

            using var scope = _webSiteSlotWebAppsClientDiagnostics.CreateScope("WebSiteSlotCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webSiteSlotWebAppsRestClient.GetSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, slot, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteSlotResource> IEnumerable<WebSiteSlotResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteSlotResource> IAsyncEnumerable<WebSiteSlotResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
