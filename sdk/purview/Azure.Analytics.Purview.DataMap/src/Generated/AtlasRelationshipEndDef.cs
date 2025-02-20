// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary>
    /// The relationshipEndDef represents an end of the relationship. The end of the
    /// relationship is defined by a type, an
    /// attribute name, cardinality and whether
    /// it  is the container end of the relationship.
    /// </summary>
    public partial class AtlasRelationshipEndDef
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

        /// <summary> Initializes a new instance of <see cref="AtlasRelationshipEndDef"/>. </summary>
        public AtlasRelationshipEndDef()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AtlasRelationshipEndDef"/>. </summary>
        /// <param name="cardinality"> single-valued attribute or multi-valued attribute. </param>
        /// <param name="description"> The description of the relationship end definition. </param>
        /// <param name="isContainer"> Determines if it is container. </param>
        /// <param name="isLegacyAttribute"> Determines if it is a legacy attribute. </param>
        /// <param name="name"> The name of the relationship end definition. </param>
        /// <param name="type"> The type of the relationship end. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AtlasRelationshipEndDef(CardinalityValue? cardinality, string description, bool? isContainer, bool? isLegacyAttribute, string name, string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Cardinality = cardinality;
            Description = description;
            IsContainer = isContainer;
            IsLegacyAttribute = isLegacyAttribute;
            Name = name;
            Type = type;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> single-valued attribute or multi-valued attribute. </summary>
        public CardinalityValue? Cardinality { get; set; }
        /// <summary> The description of the relationship end definition. </summary>
        public string Description { get; set; }
        /// <summary> Determines if it is container. </summary>
        public bool? IsContainer { get; set; }
        /// <summary> Determines if it is a legacy attribute. </summary>
        public bool? IsLegacyAttribute { get; set; }
        /// <summary> The name of the relationship end definition. </summary>
        public string Name { get; set; }
        /// <summary> The type of the relationship end. </summary>
        public string Type { get; set; }
    }
}
