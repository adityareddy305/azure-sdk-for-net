// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Sphere.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableSphereSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _sphereCatalogCatalogsClientDiagnostics;
        private CatalogsRestOperations _sphereCatalogCatalogsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableSphereSubscriptionResource"/> class for mocking. </summary>
        protected MockableSphereSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSphereSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSphereSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SphereCatalogCatalogsClientDiagnostics => _sphereCatalogCatalogsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Sphere", SphereCatalogResource.ResourceType.Namespace, Diagnostics);
        private CatalogsRestOperations SphereCatalogCatalogsRestClient => _sphereCatalogCatalogsRestClient ??= new CatalogsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SphereCatalogResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List Catalog resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureSphere/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SphereCatalogResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SphereCatalogResource> GetSphereCatalogsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SphereCatalogCatalogsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SphereCatalogCatalogsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SphereCatalogResource(Client, SphereCatalogData.DeserializeSphereCatalogData(e)), SphereCatalogCatalogsClientDiagnostics, Pipeline, "MockableSphereSubscriptionResource.GetSphereCatalogs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Catalog resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureSphere/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SphereCatalogResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SphereCatalogResource> GetSphereCatalogs(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SphereCatalogCatalogsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SphereCatalogCatalogsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SphereCatalogResource(Client, SphereCatalogData.DeserializeSphereCatalogData(e)), SphereCatalogCatalogsClientDiagnostics, Pipeline, "MockableSphereSubscriptionResource.GetSphereCatalogs", "value", "nextLink", cancellationToken);
        }
    }
}
