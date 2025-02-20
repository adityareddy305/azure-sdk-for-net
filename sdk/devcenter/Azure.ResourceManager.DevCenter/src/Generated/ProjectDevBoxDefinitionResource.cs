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

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A Class representing a ProjectDevBoxDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ProjectDevBoxDefinitionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetProjectDevBoxDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="DevCenterProjectResource"/> using the GetProjectDevBoxDefinition method.
    /// </summary>
    public partial class ProjectDevBoxDefinitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ProjectDevBoxDefinitionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="projectName"> The projectName. </param>
        /// <param name="devBoxDefinitionName"> The devBoxDefinitionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string projectName, string devBoxDefinitionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics;
        private readonly DevBoxDefinitionsRestOperations _projectDevBoxDefinitionDevBoxDefinitionsRestClient;
        private readonly DevBoxDefinitionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevCenter/projects/devboxdefinitions";

        /// <summary> Initializes a new instance of the <see cref="ProjectDevBoxDefinitionResource"/> class for mocking. </summary>
        protected ProjectDevBoxDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProjectDevBoxDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ProjectDevBoxDefinitionResource(ArmClient client, DevBoxDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ProjectDevBoxDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProjectDevBoxDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string projectDevBoxDefinitionDevBoxDefinitionsApiVersion);
            _projectDevBoxDefinitionDevBoxDefinitionsRestClient = new DevBoxDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, projectDevBoxDefinitionDevBoxDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DevBoxDefinitionData Data
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
        /// Gets a Dev Box definition configured for a project
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_GetByProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProjectDevBoxDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProjectDevBoxDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProjectDevBoxDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Dev Box definition configured for a project
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_GetByProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProjectDevBoxDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ProjectDevBoxDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProject(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProjectDevBoxDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
