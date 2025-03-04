// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ImpactReporting
{
    /// <summary>
    /// A Class representing an ImpactCategory along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ImpactCategoryResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetImpactCategoryResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetImpactCategory method.
    /// </summary>
    public partial class ImpactCategoryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ImpactCategoryResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="impactCategoryName"> The impactCategoryName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string impactCategoryName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Impact/impactCategories/{impactCategoryName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _impactCategoryClientDiagnostics;
        private readonly ImpactCategoriesRestOperations _impactCategoryRestClient;
        private readonly ImpactCategoryData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Impact/impactCategories";

        /// <summary> Initializes a new instance of the <see cref="ImpactCategoryResource"/> class for mocking. </summary>
        protected ImpactCategoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ImpactCategoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ImpactCategoryResource(ArmClient client, ImpactCategoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ImpactCategoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ImpactCategoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _impactCategoryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ImpactReporting", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string impactCategoryApiVersion);
            _impactCategoryRestClient = new ImpactCategoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, impactCategoryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ImpactCategoryData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a ImpactCategory
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Impact/impactCategories/{impactCategoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactCategory_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ImpactCategoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ImpactCategoryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _impactCategoryClientDiagnostics.CreateScope("ImpactCategoryResource.Get");
            scope.Start();
            try
            {
                var response = await _impactCategoryRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ImpactCategoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ImpactCategory
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Impact/impactCategories/{impactCategoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactCategory_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ImpactCategoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ImpactCategoryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _impactCategoryClientDiagnostics.CreateScope("ImpactCategoryResource.Get");
            scope.Start();
            try
            {
                var response = _impactCategoryRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ImpactCategoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
