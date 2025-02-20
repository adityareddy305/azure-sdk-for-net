// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementOpenIdConnectProviderPatch : IUtf8JsonSerializable, IJsonModel<ApiManagementOpenIdConnectProviderPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementOpenIdConnectProviderPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiManagementOpenIdConnectProviderPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementOpenIdConnectProviderPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementOpenIdConnectProviderPatch)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(MetadataEndpoint))
            {
                writer.WritePropertyName("metadataEndpoint"u8);
                writer.WriteStringValue(MetadataEndpoint);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            if (Optional.IsDefined(UseInTestConsole))
            {
                writer.WritePropertyName("useInTestConsole"u8);
                writer.WriteBooleanValue(UseInTestConsole.Value);
            }
            if (Optional.IsDefined(UseInApiDocumentation))
            {
                writer.WritePropertyName("useInApiDocumentation"u8);
                writer.WriteBooleanValue(UseInApiDocumentation.Value);
            }
            writer.WriteEndObject();
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

        ApiManagementOpenIdConnectProviderPatch IJsonModel<ApiManagementOpenIdConnectProviderPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementOpenIdConnectProviderPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementOpenIdConnectProviderPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementOpenIdConnectProviderPatch(document.RootElement, options);
        }

        internal static ApiManagementOpenIdConnectProviderPatch DeserializeApiManagementOpenIdConnectProviderPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            string description = default;
            string metadataEndpoint = default;
            string clientId = default;
            string clientSecret = default;
            bool? useInTestConsole = default;
            bool? useInApiDocumentation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadataEndpoint"u8))
                        {
                            metadataEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            clientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            clientSecret = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("useInTestConsole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useInTestConsole = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useInApiDocumentation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useInApiDocumentation = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiManagementOpenIdConnectProviderPatch(
                displayName,
                description,
                metadataEndpoint,
                clientId,
                clientSecret,
                useInTestConsole,
                useInApiDocumentation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementOpenIdConnectProviderPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementOpenIdConnectProviderPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementOpenIdConnectProviderPatch)} does not support writing '{options.Format}' format.");
            }
        }

        ApiManagementOpenIdConnectProviderPatch IPersistableModel<ApiManagementOpenIdConnectProviderPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementOpenIdConnectProviderPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiManagementOpenIdConnectProviderPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementOpenIdConnectProviderPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementOpenIdConnectProviderPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
