// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubFallbackRouteProperties : IUtf8JsonSerializable, IJsonModel<IotHubFallbackRouteProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubFallbackRouteProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotHubFallbackRouteProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubFallbackRouteProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubFallbackRouteProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source.ToString());
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition"u8);
                writer.WriteStringValue(Condition);
            }
            writer.WritePropertyName("endpointNames"u8);
            writer.WriteStartArray();
            foreach (var item in EndpointNames)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
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

        IotHubFallbackRouteProperties IJsonModel<IotHubFallbackRouteProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubFallbackRouteProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubFallbackRouteProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubFallbackRouteProperties(document.RootElement, options);
        }

        internal static IotHubFallbackRouteProperties DeserializeIotHubFallbackRouteProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IotHubRoutingSource source = default;
            string condition = default;
            IList<string> endpointNames = default;
            bool isEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = new IotHubRoutingSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("condition"u8))
                {
                    condition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointNames"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    endpointNames = array;
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotHubFallbackRouteProperties(
                name,
                source,
                condition,
                endpointNames,
                isEnabled,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubFallbackRouteProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubFallbackRouteProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubFallbackRouteProperties)} does not support writing '{options.Format}' format.");
            }
        }

        IotHubFallbackRouteProperties IPersistableModel<IotHubFallbackRouteProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubFallbackRouteProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubFallbackRouteProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubFallbackRouteProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubFallbackRouteProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
