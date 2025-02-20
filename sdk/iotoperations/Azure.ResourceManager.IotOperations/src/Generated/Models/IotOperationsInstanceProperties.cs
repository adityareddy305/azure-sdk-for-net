// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> The properties of the Instance resource. </summary>
    public partial class IotOperationsInstanceProperties
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

        /// <summary> Initializes a new instance of <see cref="IotOperationsInstanceProperties"/>. </summary>
        /// <param name="schemaRegistryRef"> The reference to the Schema Registry for this AIO Instance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaRegistryRef"/> is null. </exception>
        public IotOperationsInstanceProperties(SchemaRegistryRef schemaRegistryRef)
        {
            Argument.AssertNotNull(schemaRegistryRef, nameof(schemaRegistryRef));

            SchemaRegistryRef = schemaRegistryRef;
        }

        /// <summary> Initializes a new instance of <see cref="IotOperationsInstanceProperties"/>. </summary>
        /// <param name="description"> Detailed description of the Instance. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="version"> The Azure IoT Operations version. </param>
        /// <param name="schemaRegistryRef"> The reference to the Schema Registry for this AIO Instance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotOperationsInstanceProperties(string description, IotOperationsProvisioningState? provisioningState, string version, SchemaRegistryRef schemaRegistryRef, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            ProvisioningState = provisioningState;
            Version = version;
            SchemaRegistryRef = schemaRegistryRef;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotOperationsInstanceProperties"/> for deserialization. </summary>
        internal IotOperationsInstanceProperties()
        {
        }

        /// <summary> Detailed description of the Instance. </summary>
        public string Description { get; set; }
        /// <summary> The status of the last operation. </summary>
        public IotOperationsProvisioningState? ProvisioningState { get; }
        /// <summary> The Azure IoT Operations version. </summary>
        public string Version { get; }
        /// <summary> The reference to the Schema Registry for this AIO Instance. </summary>
        internal SchemaRegistryRef SchemaRegistryRef { get; set; }
        /// <summary> The resource ID of the Schema Registry. </summary>
        public ResourceIdentifier SchemaRegistryRefResourceId
        {
            get => SchemaRegistryRef is null ? default : SchemaRegistryRef.ResourceId;
            set => SchemaRegistryRef = new SchemaRegistryRef(value);
        }
    }
}
