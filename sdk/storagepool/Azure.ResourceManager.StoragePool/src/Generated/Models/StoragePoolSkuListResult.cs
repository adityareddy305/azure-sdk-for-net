// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> List Disk Pool skus operation response. </summary>
    internal partial class StoragePoolSkuListResult
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

        /// <summary> Initializes a new instance of <see cref="StoragePoolSkuListResult"/>. </summary>
        internal StoragePoolSkuListResult()
        {
            Value = new ChangeTrackingList<StoragePoolSkuInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="StoragePoolSkuListResult"/>. </summary>
        /// <param name="value"> The list of StoragePool resource skus. </param>
        /// <param name="nextLink"> URI to fetch the next section of the paginated response. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StoragePoolSkuListResult(IReadOnlyList<StoragePoolSkuInfo> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of StoragePool resource skus. </summary>
        public IReadOnlyList<StoragePoolSkuInfo> Value { get; }
        /// <summary> URI to fetch the next section of the paginated response. </summary>
        public string NextLink { get; }
    }
}
