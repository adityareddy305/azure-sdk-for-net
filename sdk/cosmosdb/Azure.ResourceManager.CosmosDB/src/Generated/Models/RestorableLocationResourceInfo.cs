// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties of the regional restorable account. </summary>
    public partial class RestorableLocationResourceInfo
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

        /// <summary> Initializes a new instance of <see cref="RestorableLocationResourceInfo"/>. </summary>
        internal RestorableLocationResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestorableLocationResourceInfo"/>. </summary>
        /// <param name="locationName"> The location of the regional restorable account. </param>
        /// <param name="regionalDatabaseAccountInstanceId"> The instance id of the regional restorable account. </param>
        /// <param name="createdOn"> The creation time of the regional restorable database account (ISO-8601 format). </param>
        /// <param name="deletedOn"> The time at which the regional restorable database account has been deleted (ISO-8601 format). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorableLocationResourceInfo(AzureLocation? locationName, string regionalDatabaseAccountInstanceId, DateTimeOffset? createdOn, DateTimeOffset? deletedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LocationName = locationName;
            RegionalDatabaseAccountInstanceId = regionalDatabaseAccountInstanceId;
            CreatedOn = createdOn;
            DeletedOn = deletedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The location of the regional restorable account. </summary>
        [WirePath("locationName")]
        public AzureLocation? LocationName { get; }
        /// <summary> The instance id of the regional restorable account. </summary>
        [WirePath("regionalDatabaseAccountInstanceId")]
        public string RegionalDatabaseAccountInstanceId { get; }
        /// <summary> The creation time of the regional restorable database account (ISO-8601 format). </summary>
        [WirePath("creationTime")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time at which the regional restorable database account has been deleted (ISO-8601 format). </summary>
        [WirePath("deletionTime")]
        public DateTimeOffset? DeletedOn { get; }
    }
}
