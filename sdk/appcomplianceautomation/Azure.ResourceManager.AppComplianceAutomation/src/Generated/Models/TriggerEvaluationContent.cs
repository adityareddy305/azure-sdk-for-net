// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Trigger evaluation request. </summary>
    public partial class TriggerEvaluationContent
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

        /// <summary> Initializes a new instance of <see cref="TriggerEvaluationContent"/>. </summary>
        /// <param name="resourceIds"> List of resource ids to be evaluated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceIds"/> is null. </exception>
        public TriggerEvaluationContent(IEnumerable<string> resourceIds)
        {
            Argument.AssertNotNull(resourceIds, nameof(resourceIds));

            ResourceIds = resourceIds.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="TriggerEvaluationContent"/>. </summary>
        /// <param name="resourceIds"> List of resource ids to be evaluated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TriggerEvaluationContent(IList<string> resourceIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceIds = resourceIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TriggerEvaluationContent"/> for deserialization. </summary>
        internal TriggerEvaluationContent()
        {
        }

        /// <summary> List of resource ids to be evaluated. </summary>
        public IList<string> ResourceIds { get; }
    }
}
