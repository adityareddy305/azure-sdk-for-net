// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The phase details properties of a database operation. </summary>
    public partial class DatabaseOperationPhaseDetails
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

        /// <summary> Initializes a new instance of <see cref="DatabaseOperationPhaseDetails"/>. </summary>
        internal DatabaseOperationPhaseDetails()
        {
            PhaseInformation = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseOperationPhaseDetails"/>. </summary>
        /// <param name="phase"> The operation phase. </param>
        /// <param name="phaseInformation"> The operation phase information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseOperationPhaseDetails(DatabaseOperationPhase? phase, IReadOnlyDictionary<string, string> phaseInformation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Phase = phase;
            PhaseInformation = phaseInformation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The operation phase. </summary>
        [WirePath("phase")]
        public DatabaseOperationPhase? Phase { get; }
        /// <summary> The operation phase information. </summary>
        [WirePath("phaseInformation")]
        public IReadOnlyDictionary<string, string> PhaseInformation { get; }
    }
}
