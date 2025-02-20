// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Azure Monitor Workspace Logs Api configurations. </summary>
    public partial class MonitorWorkspaceLogsApiConfig
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

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceLogsApiConfig"/>. </summary>
        /// <param name="dataCollectionEndpointUri"> Data collection endpoint ingestion url. </param>
        /// <param name="stream"> Stream name in destination. Azure Monitor stream is related to the destination table. </param>
        /// <param name="dataCollectionRule"> Data Collection Rule (DCR) immutable id. </param>
        /// <param name="schema"> The schema mapping for incoming data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointUri"/>, <paramref name="stream"/>, <paramref name="dataCollectionRule"/> or <paramref name="schema"/> is null. </exception>
        public MonitorWorkspaceLogsApiConfig(Uri dataCollectionEndpointUri, string stream, string dataCollectionRule, MonitorWorkspaceLogsSchemaMap schema)
        {
            Argument.AssertNotNull(dataCollectionEndpointUri, nameof(dataCollectionEndpointUri));
            Argument.AssertNotNull(stream, nameof(stream));
            Argument.AssertNotNull(dataCollectionRule, nameof(dataCollectionRule));
            Argument.AssertNotNull(schema, nameof(schema));

            DataCollectionEndpointUri = dataCollectionEndpointUri;
            Stream = stream;
            DataCollectionRule = dataCollectionRule;
            Schema = schema;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceLogsApiConfig"/>. </summary>
        /// <param name="dataCollectionEndpointUri"> Data collection endpoint ingestion url. </param>
        /// <param name="stream"> Stream name in destination. Azure Monitor stream is related to the destination table. </param>
        /// <param name="dataCollectionRule"> Data Collection Rule (DCR) immutable id. </param>
        /// <param name="schema"> The schema mapping for incoming data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorWorkspaceLogsApiConfig(Uri dataCollectionEndpointUri, string stream, string dataCollectionRule, MonitorWorkspaceLogsSchemaMap schema, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataCollectionEndpointUri = dataCollectionEndpointUri;
            Stream = stream;
            DataCollectionRule = dataCollectionRule;
            Schema = schema;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceLogsApiConfig"/> for deserialization. </summary>
        internal MonitorWorkspaceLogsApiConfig()
        {
        }

        /// <summary> Data collection endpoint ingestion url. </summary>
        public Uri DataCollectionEndpointUri { get; set; }
        /// <summary> Stream name in destination. Azure Monitor stream is related to the destination table. </summary>
        public string Stream { get; set; }
        /// <summary> Data Collection Rule (DCR) immutable id. </summary>
        public string DataCollectionRule { get; set; }
        /// <summary> The schema mapping for incoming data. </summary>
        public MonitorWorkspaceLogsSchemaMap Schema { get; set; }
    }
}
