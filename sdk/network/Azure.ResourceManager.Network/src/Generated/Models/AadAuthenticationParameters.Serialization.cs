// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AadAuthenticationParameters : IUtf8JsonSerializable, IJsonModel<AadAuthenticationParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AadAuthenticationParameters>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AadAuthenticationParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AadAuthenticationParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AadAuthenticationParameters)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AadTenant))
            {
                writer.WritePropertyName("aadTenant"u8);
                writer.WriteStringValue(AadTenant);
            }
            if (Optional.IsDefined(AadAudience))
            {
                writer.WritePropertyName("aadAudience"u8);
                writer.WriteStringValue(AadAudience);
            }
            if (Optional.IsDefined(AadIssuer))
            {
                writer.WritePropertyName("aadIssuer"u8);
                writer.WriteStringValue(AadIssuer);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AadAuthenticationParameters IJsonModel<AadAuthenticationParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AadAuthenticationParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AadAuthenticationParameters)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAadAuthenticationParameters(document.RootElement, options);
        }

        internal static AadAuthenticationParameters DeserializeAadAuthenticationParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string aadTenant = default;
            string aadAudience = default;
            string aadIssuer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aadTenant"u8))
                {
                    aadTenant = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadAudience"u8))
                {
                    aadAudience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadIssuer"u8))
                {
                    aadIssuer = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AadAuthenticationParameters(aadTenant, aadAudience, aadIssuer, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AadAuthenticationParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AadAuthenticationParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AadAuthenticationParameters)} does not support writing '{options.Format}' format.");
            }
        }

        AadAuthenticationParameters IPersistableModel<AadAuthenticationParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AadAuthenticationParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAadAuthenticationParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AadAuthenticationParameters)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AadAuthenticationParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
