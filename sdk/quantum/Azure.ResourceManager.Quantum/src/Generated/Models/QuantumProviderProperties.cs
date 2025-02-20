// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> Provider properties. </summary>
    public partial class QuantumProviderProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuantumProviderProperties"/>. </summary>
        internal QuantumProviderProperties()
        {
            Targets = new ChangeTrackingList<ProviderTargetDescription>();
            Skus = new ChangeTrackingList<ProviderSkuDescription>();
            QuotaDimensions = new ChangeTrackingList<QuantumQuotaDimension>();
            PricingDimensions = new ChangeTrackingList<ProviderPricingDimension>();
        }

        /// <summary> Initializes a new instance of <see cref="QuantumProviderProperties"/>. </summary>
        /// <param name="description"> A description about this provider. </param>
        /// <param name="providerType"> Provider type. </param>
        /// <param name="company"> Company name. </param>
        /// <param name="defaultEndpoint"> Provider's default endpoint. </param>
        /// <param name="aad"> Azure Active Directory info. </param>
        /// <param name="managedApplication"> Provider's Managed-Application info. </param>
        /// <param name="targets"> The list of targets available from this provider. </param>
        /// <param name="skus"> The list of skus available from this provider. </param>
        /// <param name="quotaDimensions"> The list of quota dimensions from the provider. </param>
        /// <param name="pricingDimensions"> The list of pricing dimensions from the provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuantumProviderProperties(string description, string providerType, string company, string defaultEndpoint, ProviderAadInfo aad, ProviderApplicationInfo managedApplication, IReadOnlyList<ProviderTargetDescription> targets, IReadOnlyList<ProviderSkuDescription> skus, IReadOnlyList<QuantumQuotaDimension> quotaDimensions, IReadOnlyList<ProviderPricingDimension> pricingDimensions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            ProviderType = providerType;
            Company = company;
            DefaultEndpoint = defaultEndpoint;
            Aad = aad;
            ManagedApplication = managedApplication;
            Targets = targets;
            Skus = skus;
            QuotaDimensions = quotaDimensions;
            PricingDimensions = pricingDimensions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A description about this provider. </summary>
        public string Description { get; }
        /// <summary> Provider type. </summary>
        public string ProviderType { get; }
        /// <summary> Company name. </summary>
        public string Company { get; }
        /// <summary> Provider's default endpoint. </summary>
        public string DefaultEndpoint { get; }
        /// <summary> Azure Active Directory info. </summary>
        public ProviderAadInfo Aad { get; }
        /// <summary> Provider's Managed-Application info. </summary>
        public ProviderApplicationInfo ManagedApplication { get; }
        /// <summary> The list of targets available from this provider. </summary>
        public IReadOnlyList<ProviderTargetDescription> Targets { get; }
        /// <summary> The list of skus available from this provider. </summary>
        public IReadOnlyList<ProviderSkuDescription> Skus { get; }
        /// <summary> The list of quota dimensions from the provider. </summary>
        public IReadOnlyList<QuantumQuotaDimension> QuotaDimensions { get; }
        /// <summary> The list of pricing dimensions from the provider. </summary>
        public IReadOnlyList<ProviderPricingDimension> PricingDimensions { get; }
    }
}
