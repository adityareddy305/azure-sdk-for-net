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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="AdaptiveNetworkHardeningResource"/> and their operations.
    /// Each <see cref="AdaptiveNetworkHardeningResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="AdaptiveNetworkHardeningCollection"/> instance call the GetAdaptiveNetworkHardenings method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class AdaptiveNetworkHardeningCollection : ArmCollection, IEnumerable<AdaptiveNetworkHardeningResource>, IAsyncEnumerable<AdaptiveNetworkHardeningResource>
    {
        private readonly ClientDiagnostics _adaptiveNetworkHardeningClientDiagnostics;
        private readonly AdaptiveNetworkHardeningsRestOperations _adaptiveNetworkHardeningRestClient;
        private readonly string _resourceNamespace;
        private readonly string _resourceType;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="AdaptiveNetworkHardeningCollection"/> class for mocking. </summary>
        protected AdaptiveNetworkHardeningCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AdaptiveNetworkHardeningCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceNamespace"> The Namespace of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="resourceName"> Name of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal AdaptiveNetworkHardeningCollection(ArmClient client, ResourceIdentifier id, string resourceNamespace, string resourceType, string resourceName) : base(client, id)
        {
            _resourceNamespace = resourceNamespace;
            _resourceType = resourceType;
            _resourceName = resourceName;
            _adaptiveNetworkHardeningClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", AdaptiveNetworkHardeningResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AdaptiveNetworkHardeningResource.ResourceType, out string adaptiveNetworkHardeningApiVersion);
            _adaptiveNetworkHardeningRestClient = new AdaptiveNetworkHardeningsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, adaptiveNetworkHardeningApiVersion);
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
        /// Gets a single Adaptive Network Hardening resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/adaptiveNetworkHardenings/{adaptiveNetworkHardeningResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveNetworkHardenings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveNetworkHardeningResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is null. </exception>
        public virtual async Task<Response<AdaptiveNetworkHardeningResource>> GetAsync(string adaptiveNetworkHardeningResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));

            using var scope = _adaptiveNetworkHardeningClientDiagnostics.CreateScope("AdaptiveNetworkHardeningCollection.Get");
            scope.Start();
            try
            {
                var response = await _adaptiveNetworkHardeningRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName, adaptiveNetworkHardeningResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AdaptiveNetworkHardeningResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a single Adaptive Network Hardening resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/adaptiveNetworkHardenings/{adaptiveNetworkHardeningResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveNetworkHardenings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveNetworkHardeningResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is null. </exception>
        public virtual Response<AdaptiveNetworkHardeningResource> Get(string adaptiveNetworkHardeningResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));

            using var scope = _adaptiveNetworkHardeningClientDiagnostics.CreateScope("AdaptiveNetworkHardeningCollection.Get");
            scope.Start();
            try
            {
                var response = _adaptiveNetworkHardeningRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName, adaptiveNetworkHardeningResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AdaptiveNetworkHardeningResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Adaptive Network Hardenings resources in scope of an extended resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/adaptiveNetworkHardenings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveNetworkHardenings_ListByExtendedResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveNetworkHardeningResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AdaptiveNetworkHardeningResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AdaptiveNetworkHardeningResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _adaptiveNetworkHardeningRestClient.CreateListByExtendedResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _adaptiveNetworkHardeningRestClient.CreateListByExtendedResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AdaptiveNetworkHardeningResource(Client, AdaptiveNetworkHardeningData.DeserializeAdaptiveNetworkHardeningData(e)), _adaptiveNetworkHardeningClientDiagnostics, Pipeline, "AdaptiveNetworkHardeningCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Adaptive Network Hardenings resources in scope of an extended resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/adaptiveNetworkHardenings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveNetworkHardenings_ListByExtendedResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveNetworkHardeningResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AdaptiveNetworkHardeningResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AdaptiveNetworkHardeningResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _adaptiveNetworkHardeningRestClient.CreateListByExtendedResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _adaptiveNetworkHardeningRestClient.CreateListByExtendedResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AdaptiveNetworkHardeningResource(Client, AdaptiveNetworkHardeningData.DeserializeAdaptiveNetworkHardeningData(e)), _adaptiveNetworkHardeningClientDiagnostics, Pipeline, "AdaptiveNetworkHardeningCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/adaptiveNetworkHardenings/{adaptiveNetworkHardeningResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveNetworkHardenings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveNetworkHardeningResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string adaptiveNetworkHardeningResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));

            using var scope = _adaptiveNetworkHardeningClientDiagnostics.CreateScope("AdaptiveNetworkHardeningCollection.Exists");
            scope.Start();
            try
            {
                var response = await _adaptiveNetworkHardeningRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName, adaptiveNetworkHardeningResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/adaptiveNetworkHardenings/{adaptiveNetworkHardeningResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveNetworkHardenings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveNetworkHardeningResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string adaptiveNetworkHardeningResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));

            using var scope = _adaptiveNetworkHardeningClientDiagnostics.CreateScope("AdaptiveNetworkHardeningCollection.Exists");
            scope.Start();
            try
            {
                var response = _adaptiveNetworkHardeningRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName, adaptiveNetworkHardeningResourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/adaptiveNetworkHardenings/{adaptiveNetworkHardeningResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveNetworkHardenings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveNetworkHardeningResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<AdaptiveNetworkHardeningResource>> GetIfExistsAsync(string adaptiveNetworkHardeningResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));

            using var scope = _adaptiveNetworkHardeningClientDiagnostics.CreateScope("AdaptiveNetworkHardeningCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _adaptiveNetworkHardeningRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName, adaptiveNetworkHardeningResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AdaptiveNetworkHardeningResource>(response.GetRawResponse());
                return Response.FromValue(new AdaptiveNetworkHardeningResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/adaptiveNetworkHardenings/{adaptiveNetworkHardeningResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveNetworkHardenings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveNetworkHardeningResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adaptiveNetworkHardeningResourceName"/> is null. </exception>
        public virtual NullableResponse<AdaptiveNetworkHardeningResource> GetIfExists(string adaptiveNetworkHardeningResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));

            using var scope = _adaptiveNetworkHardeningClientDiagnostics.CreateScope("AdaptiveNetworkHardeningCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _adaptiveNetworkHardeningRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceNamespace, _resourceType, _resourceName, adaptiveNetworkHardeningResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AdaptiveNetworkHardeningResource>(response.GetRawResponse());
                return Response.FromValue(new AdaptiveNetworkHardeningResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AdaptiveNetworkHardeningResource> IEnumerable<AdaptiveNetworkHardeningResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AdaptiveNetworkHardeningResource> IAsyncEnumerable<AdaptiveNetworkHardeningResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
