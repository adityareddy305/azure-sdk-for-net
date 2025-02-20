// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary>
    /// Parameters supplied to the CreateOrUpdate Namespace AuthorizationRules.
    /// Serialized Name: SharedAccessAuthorizationRuleCreateOrUpdateParameters
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class SharedAccessAuthorizationRuleCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="SharedAccessAuthorizationRuleCreateOrUpdateContent"/>. </summary>
        /// <param name="properties">
        /// Properties of the Namespace AuthorizationRules.
        /// Serialized Name: SharedAccessAuthorizationRuleCreateOrUpdateParameters.properties
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SharedAccessAuthorizationRuleCreateOrUpdateContent(SharedAccessAuthorizationRuleProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="SharedAccessAuthorizationRuleCreateOrUpdateContent"/>. </summary>
        /// <param name="properties">
        /// Properties of the Namespace AuthorizationRules.
        /// Serialized Name: SharedAccessAuthorizationRuleCreateOrUpdateParameters.properties
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedAccessAuthorizationRuleCreateOrUpdateContent(SharedAccessAuthorizationRuleProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SharedAccessAuthorizationRuleCreateOrUpdateContent"/> for deserialization. </summary>
        internal SharedAccessAuthorizationRuleCreateOrUpdateContent()
        {
        }

        /// <summary>
        /// Properties of the Namespace AuthorizationRules.
        /// Serialized Name: SharedAccessAuthorizationRuleCreateOrUpdateParameters.properties
        /// </summary>
        public SharedAccessAuthorizationRuleProperties Properties { get; }
    }
}
