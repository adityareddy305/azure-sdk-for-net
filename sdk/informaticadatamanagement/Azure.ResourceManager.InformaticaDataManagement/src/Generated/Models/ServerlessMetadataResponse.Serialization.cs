// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    public partial class ServerlessMetadataResponse : IUtf8JsonSerializable, IJsonModel<ServerlessMetadataResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerlessMetadataResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServerlessMetadataResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessMetadataResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessMetadataResponse)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RuntimeType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RuntimeType.Value.ToString());
            }
            if (Optional.IsDefined(ServerlessConfigProperties))
            {
                writer.WritePropertyName("serverlessConfigProperties"u8);
                writer.WriteObjectValue(ServerlessConfigProperties, options);
            }
            if (Optional.IsDefined(ServerlessRuntimeConfigProperties))
            {
                writer.WritePropertyName("serverlessRuntimeConfigProperties"u8);
                writer.WriteObjectValue(ServerlessRuntimeConfigProperties, options);
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

        ServerlessMetadataResponse IJsonModel<ServerlessMetadataResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessMetadataResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessMetadataResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerlessMetadataResponse(document.RootElement, options);
        }

        internal static ServerlessMetadataResponse DeserializeServerlessMetadataResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InformaticaRuntimeType? type = default;
            ServerlessConfigProperties serverlessConfigProperties = default;
            ServerlessRuntimeConfigProperties serverlessRuntimeConfigProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new InformaticaRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverlessConfigProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverlessConfigProperties = ServerlessConfigProperties.DeserializeServerlessConfigProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serverlessRuntimeConfigProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverlessRuntimeConfigProperties = ServerlessRuntimeConfigProperties.DeserializeServerlessRuntimeConfigProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServerlessMetadataResponse(type, serverlessConfigProperties, serverlessRuntimeConfigProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerlessMetadataResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessMetadataResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerlessMetadataResponse)} does not support writing '{options.Format}' format.");
            }
        }

        ServerlessMetadataResponse IPersistableModel<ServerlessMetadataResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessMetadataResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerlessMetadataResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerlessMetadataResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerlessMetadataResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
