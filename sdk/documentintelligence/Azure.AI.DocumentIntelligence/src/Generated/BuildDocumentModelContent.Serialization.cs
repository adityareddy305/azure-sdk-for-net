// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class BuildDocumentModelContent : IUtf8JsonSerializable, IJsonModel<BuildDocumentModelContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BuildDocumentModelContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BuildDocumentModelContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuildDocumentModelContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BuildDocumentModelContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("buildMode"u8);
            writer.WriteStringValue(BuildMode.ToString());
            if (Optional.IsDefined(AzureBlobSource))
            {
                writer.WritePropertyName("azureBlobSource"u8);
                writer.WriteObjectValue(AzureBlobSource, options);
            }
            if (Optional.IsDefined(AzureBlobFileListSource))
            {
                writer.WritePropertyName("azureBlobFileListSource"u8);
                writer.WriteObjectValue(AzureBlobFileListSource, options);
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
            if (Optional.IsDefined(MaxTrainingHours))
            {
                writer.WritePropertyName("maxTrainingHours"u8);
                writer.WriteNumberValue(MaxTrainingHours.Value);
            }
            if (Optional.IsDefined(AllowOverwrite))
            {
                writer.WritePropertyName("allowOverwrite"u8);
                writer.WriteBooleanValue(AllowOverwrite.Value);
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

        BuildDocumentModelContent IJsonModel<BuildDocumentModelContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuildDocumentModelContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BuildDocumentModelContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBuildDocumentModelContent(document.RootElement, options);
        }

        internal static BuildDocumentModelContent DeserializeBuildDocumentModelContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelId = default;
            string description = default;
            DocumentBuildMode buildMode = default;
            AzureBlobContentSource azureBlobSource = default;
            AzureBlobFileListContentSource azureBlobFileListSource = default;
            IDictionary<string, string> tags = default;
            float? maxTrainingHours = default;
            bool? allowOverwrite = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("buildMode"u8))
                {
                    buildMode = new DocumentBuildMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureBlobSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobSource = AzureBlobContentSource.DeserializeAzureBlobContentSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureBlobFileListSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobFileListSource = AzureBlobFileListContentSource.DeserializeAzureBlobFileListContentSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("maxTrainingHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTrainingHours = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("allowOverwrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowOverwrite = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BuildDocumentModelContent(
                modelId,
                description,
                buildMode,
                azureBlobSource,
                azureBlobFileListSource,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                maxTrainingHours,
                allowOverwrite,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BuildDocumentModelContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuildDocumentModelContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BuildDocumentModelContent)} does not support writing '{options.Format}' format.");
            }
        }

        BuildDocumentModelContent IPersistableModel<BuildDocumentModelContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuildDocumentModelContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBuildDocumentModelContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BuildDocumentModelContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BuildDocumentModelContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BuildDocumentModelContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBuildDocumentModelContent(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
