// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    internal partial class DeviceRegistryX509Credentials : IUtf8JsonSerializable, IJsonModel<DeviceRegistryX509Credentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceRegistryX509Credentials>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeviceRegistryX509Credentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryX509Credentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceRegistryX509Credentials)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("certificateSecretName"u8);
            writer.WriteStringValue(CertificateSecretName);
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

        DeviceRegistryX509Credentials IJsonModel<DeviceRegistryX509Credentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryX509Credentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceRegistryX509Credentials)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceRegistryX509Credentials(document.RootElement, options);
        }

        internal static DeviceRegistryX509Credentials DeserializeDeviceRegistryX509Credentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string certificateSecretName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateSecretName"u8))
                {
                    certificateSecretName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeviceRegistryX509Credentials(certificateSecretName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceRegistryX509Credentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryX509Credentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceRegistryX509Credentials)} does not support writing '{options.Format}' format.");
            }
        }

        DeviceRegistryX509Credentials IPersistableModel<DeviceRegistryX509Credentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryX509Credentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceRegistryX509Credentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceRegistryX509Credentials)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceRegistryX509Credentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
