// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a NotificationHub ApnsCredential. </summary>
    public partial class NotificationHubApnsCredential
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

        /// <summary> Initializes a new instance of <see cref="NotificationHubApnsCredential"/>. </summary>
        /// <param name="endpoint"> Gets or sets the endpoint of this credential. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public NotificationHubApnsCredential(Uri endpoint)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubApnsCredential"/>. </summary>
        /// <param name="apnsCertificate"> Gets or sets the APNS certificate. </param>
        /// <param name="certificateKey"> Gets or sets the certificate key. </param>
        /// <param name="endpoint"> Gets or sets the endpoint of this credential. </param>
        /// <param name="thumbprintString"> Gets or sets the APNS certificate Thumbprint. </param>
        /// <param name="keyId">
        /// Gets or sets a 10-character key identifier (kid) key, obtained from
        /// your developer account
        /// </param>
        /// <param name="appName"> Gets or sets the name of the application. </param>
        /// <param name="appId">
        /// Gets or sets the issuer (iss) registered claim key, whose value is
        /// your 10-character Team ID, obtained from your developer account
        /// </param>
        /// <param name="token">
        /// Gets or sets provider Authentication Token, obtained through your
        /// developer account
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubApnsCredential(string apnsCertificate, string certificateKey, Uri endpoint, string thumbprintString, string keyId, string appName, string appId, string token, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApnsCertificate = apnsCertificate;
            CertificateKey = certificateKey;
            Endpoint = endpoint;
            ThumbprintString = thumbprintString;
            KeyId = keyId;
            AppName = appName;
            AppId = appId;
            Token = token;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the APNS certificate. </summary>
        public string ApnsCertificate { get; set; }
        /// <summary> Gets or sets the certificate key. </summary>
        public string CertificateKey { get; set; }
        /// <summary> Gets or sets the endpoint of this credential. </summary>
        public Uri Endpoint { get; set; }
        /// <summary> Gets or sets the APNS certificate Thumbprint. </summary>
        public string ThumbprintString { get; set; }
        /// <summary>
        /// Gets or sets a 10-character key identifier (kid) key, obtained from
        /// your developer account
        /// </summary>
        public string KeyId { get; set; }
        /// <summary> Gets or sets the name of the application. </summary>
        public string AppName { get; set; }
        /// <summary>
        /// Gets or sets the issuer (iss) registered claim key, whose value is
        /// your 10-character Team ID, obtained from your developer account
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// Gets or sets provider Authentication Token, obtained through your
        /// developer account
        /// </summary>
        public string Token { get; set; }
    }
}
