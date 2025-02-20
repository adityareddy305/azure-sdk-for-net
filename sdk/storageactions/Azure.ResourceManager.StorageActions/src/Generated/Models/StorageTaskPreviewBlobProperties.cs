// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageActions.Models
{
    /// <summary> Storage task preview container properties. </summary>
    public partial class StorageTaskPreviewBlobProperties
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

        /// <summary> Initializes a new instance of <see cref="StorageTaskPreviewBlobProperties"/>. </summary>
        public StorageTaskPreviewBlobProperties()
        {
            Properties = new ChangeTrackingList<StorageTaskPreviewKeyValueProperties>();
            Metadata = new ChangeTrackingList<StorageTaskPreviewKeyValueProperties>();
            Tags = new ChangeTrackingList<StorageTaskPreviewKeyValueProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageTaskPreviewBlobProperties"/>. </summary>
        /// <param name="name"> Name of test blob. </param>
        /// <param name="properties"> properties key value pairs to be tested for a match against the provided condition. </param>
        /// <param name="metadata"> metadata key value pairs to be tested for a match against the provided condition. </param>
        /// <param name="tags"> tags key value pairs to be tested for a match against the provided condition. </param>
        /// <param name="matchedBlock"> Represents the condition block name that matched blob properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageTaskPreviewBlobProperties(string name, IList<StorageTaskPreviewKeyValueProperties> properties, IList<StorageTaskPreviewKeyValueProperties> metadata, IList<StorageTaskPreviewKeyValueProperties> tags, MatchedBlockName? matchedBlock, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Properties = properties;
            Metadata = metadata;
            Tags = tags;
            MatchedBlock = matchedBlock;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of test blob. </summary>
        public string Name { get; set; }
        /// <summary> properties key value pairs to be tested for a match against the provided condition. </summary>
        public IList<StorageTaskPreviewKeyValueProperties> Properties { get; }
        /// <summary> metadata key value pairs to be tested for a match against the provided condition. </summary>
        public IList<StorageTaskPreviewKeyValueProperties> Metadata { get; }
        /// <summary> tags key value pairs to be tested for a match against the provided condition. </summary>
        public IList<StorageTaskPreviewKeyValueProperties> Tags { get; }
        /// <summary> Represents the condition block name that matched blob properties. </summary>
        public MatchedBlockName? MatchedBlock { get; }
    }
}
