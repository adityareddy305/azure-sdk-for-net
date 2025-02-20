// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service. </summary>
    internal partial class CosmosDBUniqueKeyPolicy
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

        /// <summary> Initializes a new instance of <see cref="CosmosDBUniqueKeyPolicy"/>. </summary>
        public CosmosDBUniqueKeyPolicy()
        {
            UniqueKeys = new ChangeTrackingList<CosmosDBUniqueKey>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBUniqueKeyPolicy"/>. </summary>
        /// <param name="uniqueKeys"> List of unique keys on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBUniqueKeyPolicy(IList<CosmosDBUniqueKey> uniqueKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UniqueKeys = uniqueKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of unique keys on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service. </summary>
        [WirePath("uniqueKeys")]
        public IList<CosmosDBUniqueKey> UniqueKeys { get; }
    }
}
