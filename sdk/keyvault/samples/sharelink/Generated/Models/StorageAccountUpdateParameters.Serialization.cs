// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    internal partial class StorageAccountUpdateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActiveKeyName))
            {
                writer.WritePropertyName("activeKeyName"u8);
                writer.WriteStringValue(ActiveKeyName);
            }
            if (Optional.IsDefined(AutoRegenerateKey))
            {
                writer.WritePropertyName("autoRegenerateKey"u8);
                writer.WriteBooleanValue(AutoRegenerateKey.Value);
            }
            if (Optional.IsDefined(RegenerationPeriod))
            {
                writer.WritePropertyName("regenerationPeriod"u8);
                writer.WriteStringValue(RegenerationPeriod);
            }
            if (Optional.IsDefined(StorageAccountAttributes))
            {
                writer.WritePropertyName("attributes"u8);
                writer.WriteObjectValue(StorageAccountAttributes);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
