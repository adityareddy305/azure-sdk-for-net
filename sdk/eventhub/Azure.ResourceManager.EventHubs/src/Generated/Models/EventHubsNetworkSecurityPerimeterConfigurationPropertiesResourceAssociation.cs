// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Information about resource association. </summary>
    public partial class EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation
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

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/>. </summary>
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/>. </summary>
        /// <param name="name"> Name of the resource association. </param>
        /// <param name="accessMode"> Access Mode of the resource association. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(string name, EventHubsResourceAssociationAccessMode? accessMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AccessMode = accessMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the resource association. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> Access Mode of the resource association. </summary>
        [WirePath("accessMode")]
        public EventHubsResourceAssociationAccessMode? AccessMode { get; }
    }
}
