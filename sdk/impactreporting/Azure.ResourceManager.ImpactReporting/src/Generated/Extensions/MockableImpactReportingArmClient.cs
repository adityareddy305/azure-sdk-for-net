// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ImpactReporting.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableImpactReportingArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableImpactReportingArmClient"/> class for mocking. </summary>
        protected MockableImpactReportingArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableImpactReportingArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableImpactReportingArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableImpactReportingArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkloadImpactResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkloadImpactResource.CreateResourceIdentifier" /> to create a <see cref="WorkloadImpactResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkloadImpactResource"/> object. </returns>
        public virtual WorkloadImpactResource GetWorkloadImpactResource(ResourceIdentifier id)
        {
            WorkloadImpactResource.ValidateResourceId(id);
            return new WorkloadImpactResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ImpactCategoryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ImpactCategoryResource.CreateResourceIdentifier" /> to create an <see cref="ImpactCategoryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImpactCategoryResource"/> object. </returns>
        public virtual ImpactCategoryResource GetImpactCategoryResource(ResourceIdentifier id)
        {
            ImpactCategoryResource.ValidateResourceId(id);
            return new ImpactCategoryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="InsightResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="InsightResource.CreateResourceIdentifier" /> to create an <see cref="InsightResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="InsightResource"/> object. </returns>
        public virtual InsightResource GetInsightResource(ResourceIdentifier id)
        {
            InsightResource.ValidateResourceId(id);
            return new InsightResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectorResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectorResource.CreateResourceIdentifier" /> to create a <see cref="ConnectorResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectorResource"/> object. </returns>
        public virtual ConnectorResource GetConnectorResource(ResourceIdentifier id)
        {
            ConnectorResource.ValidateResourceId(id);
            return new ConnectorResource(Client, id);
        }
    }
}
