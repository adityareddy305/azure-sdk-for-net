// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a NotificationHub BrowserCredential. </summary>
    public partial class BrowserCredential
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

        /// <summary> Initializes a new instance of <see cref="BrowserCredential"/>. </summary>
        /// <param name="subject"> Gets or sets web push subject. </param>
        /// <param name="vapidPrivateKey"> Gets or sets VAPID private key. </param>
        /// <param name="vapidPublicKey"> Gets or sets VAPID public key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subject"/>, <paramref name="vapidPrivateKey"/> or <paramref name="vapidPublicKey"/> is null. </exception>
        public BrowserCredential(string subject, string vapidPrivateKey, string vapidPublicKey)
        {
            Argument.AssertNotNull(subject, nameof(subject));
            Argument.AssertNotNull(vapidPrivateKey, nameof(vapidPrivateKey));
            Argument.AssertNotNull(vapidPublicKey, nameof(vapidPublicKey));

            Subject = subject;
            VapidPrivateKey = vapidPrivateKey;
            VapidPublicKey = vapidPublicKey;
        }

        /// <summary> Initializes a new instance of <see cref="BrowserCredential"/>. </summary>
        /// <param name="subject"> Gets or sets web push subject. </param>
        /// <param name="vapidPrivateKey"> Gets or sets VAPID private key. </param>
        /// <param name="vapidPublicKey"> Gets or sets VAPID public key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BrowserCredential(string subject, string vapidPrivateKey, string vapidPublicKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Subject = subject;
            VapidPrivateKey = vapidPrivateKey;
            VapidPublicKey = vapidPublicKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BrowserCredential"/> for deserialization. </summary>
        internal BrowserCredential()
        {
        }

        /// <summary> Gets or sets web push subject. </summary>
        public string Subject { get; set; }
        /// <summary> Gets or sets VAPID private key. </summary>
        public string VapidPrivateKey { get; set; }
        /// <summary> Gets or sets VAPID public key. </summary>
        public string VapidPublicKey { get; set; }
    }
}
