// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The UpsertManagedServerOperationParameters. </summary>
    public partial class UpsertManagedServerOperationParameters
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

        /// <summary> Initializes a new instance of <see cref="UpsertManagedServerOperationParameters"/>. </summary>
        internal UpsertManagedServerOperationParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpsertManagedServerOperationParameters"/>. </summary>
        /// <param name="family"></param>
        /// <param name="tier"></param>
        /// <param name="vCores"></param>
        /// <param name="storageSizeInGB"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpsertManagedServerOperationParameters(string family, string tier, int? vCores, int? storageSizeInGB, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Family = family;
            Tier = tier;
            VCores = vCores;
            StorageSizeInGB = storageSizeInGB;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the family. </summary>
        [WirePath("family")]
        public string Family { get; }
        /// <summary> Gets the tier. </summary>
        [WirePath("tier")]
        public string Tier { get; }
        /// <summary> Gets the v cores. </summary>
        [WirePath("vCores")]
        public int? VCores { get; }
        /// <summary> Gets the storage size in gb. </summary>
        [WirePath("storageSizeInGB")]
        public int? StorageSizeInGB { get; }
    }
}
