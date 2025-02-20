// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The container group encryption properties. </summary>
    public partial class ContainerGroupEncryptionProperties
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

        /// <summary> Initializes a new instance of <see cref="ContainerGroupEncryptionProperties"/>. </summary>
        /// <param name="vaultBaseUri"> The keyvault base url. </param>
        /// <param name="keyName"> The encryption key name. </param>
        /// <param name="keyVersion"> The encryption key version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUri"/>, <paramref name="keyName"/> or <paramref name="keyVersion"/> is null. </exception>
        public ContainerGroupEncryptionProperties(Uri vaultBaseUri, string keyName, string keyVersion)
        {
            Argument.AssertNotNull(vaultBaseUri, nameof(vaultBaseUri));
            Argument.AssertNotNull(keyName, nameof(keyName));
            Argument.AssertNotNull(keyVersion, nameof(keyVersion));

            VaultBaseUri = vaultBaseUri;
            KeyName = keyName;
            KeyVersion = keyVersion;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupEncryptionProperties"/>. </summary>
        /// <param name="vaultBaseUri"> The keyvault base url. </param>
        /// <param name="keyName"> The encryption key name. </param>
        /// <param name="keyVersion"> The encryption key version. </param>
        /// <param name="identity"> The keyvault managed identity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerGroupEncryptionProperties(Uri vaultBaseUri, string keyName, string keyVersion, string identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VaultBaseUri = vaultBaseUri;
            KeyName = keyName;
            KeyVersion = keyVersion;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupEncryptionProperties"/> for deserialization. </summary>
        internal ContainerGroupEncryptionProperties()
        {
        }

        /// <summary> The keyvault base url. </summary>
        public Uri VaultBaseUri { get; set; }
        /// <summary> The encryption key name. </summary>
        public string KeyName { get; set; }
        /// <summary> The encryption key version. </summary>
        public string KeyVersion { get; set; }
        /// <summary> The keyvault managed identity. </summary>
        public string Identity { get; set; }
    }
}
