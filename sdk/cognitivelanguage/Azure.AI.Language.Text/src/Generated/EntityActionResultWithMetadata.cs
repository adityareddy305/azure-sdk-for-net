// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Text
{
    /// <summary> Entity documents result with metadata. </summary>
    public partial class EntityActionResultWithMetadata
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

        /// <summary> Initializes a new instance of <see cref="EntityActionResultWithMetadata"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/> or <paramref name="entities"/> is null. </exception>
        internal EntityActionResultWithMetadata(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<NamedEntityWithMetadata> entities)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(entities, nameof(entities));

            Id = id;
            Warnings = warnings.ToList();
            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="EntityActionResultWithMetadata"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityActionResultWithMetadata(string id, IReadOnlyList<DocumentWarning> warnings, DocumentStatistics statistics, IReadOnlyList<NamedEntityWithMetadata> entities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Warnings = warnings;
            Statistics = statistics;
            Entities = entities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EntityActionResultWithMetadata"/> for deserialization. </summary>
        internal EntityActionResultWithMetadata()
        {
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyList<DocumentWarning> Warnings { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; }
        /// <summary> Recognized entities in the document. </summary>
        public IReadOnlyList<NamedEntityWithMetadata> Entities { get; }
    }
}
