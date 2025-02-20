// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of column in sync group table. </summary>
    public partial class SyncGroupSchemaTableColumn
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

        /// <summary> Initializes a new instance of <see cref="SyncGroupSchemaTableColumn"/>. </summary>
        public SyncGroupSchemaTableColumn()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SyncGroupSchemaTableColumn"/>. </summary>
        /// <param name="quotedName"> Quoted name of sync group table column. </param>
        /// <param name="dataSize"> Data size of the column. </param>
        /// <param name="dataType"> Data type of the column. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SyncGroupSchemaTableColumn(string quotedName, string dataSize, string dataType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QuotedName = quotedName;
            DataSize = dataSize;
            DataType = dataType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Quoted name of sync group table column. </summary>
        [WirePath("quotedName")]
        public string QuotedName { get; set; }
        /// <summary> Data size of the column. </summary>
        [WirePath("dataSize")]
        public string DataSize { get; set; }
        /// <summary> Data type of the column. </summary>
        [WirePath("dataType")]
        public string DataType { get; set; }
    }
}
