// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    public partial class DocumentTranslationFileFormat : IUtf8JsonSerializable, IJsonModel<DocumentTranslationFileFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentTranslationFileFormat>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DocumentTranslationFileFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentTranslationFileFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentTranslationFileFormat)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("format"u8);
            writer.WriteStringValue(Format);
            writer.WritePropertyName("fileExtensions"u8);
            writer.WriteStartArray();
            foreach (var item in FileExtensions)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("contentTypes"u8);
            writer.WriteStartArray();
            foreach (var item in ContentTypes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(DefaultFormatVersion))
            {
                writer.WritePropertyName("defaultVersion"u8);
                writer.WriteStringValue(DefaultFormatVersion);
            }
            if (Optional.IsCollectionDefined(FormatVersions))
            {
                writer.WritePropertyName("versions"u8);
                writer.WriteStartArray();
                foreach (var item in FormatVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
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

        DocumentTranslationFileFormat IJsonModel<DocumentTranslationFileFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentTranslationFileFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentTranslationFileFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentTranslationFileFormat(document.RootElement, options);
        }

        internal static DocumentTranslationFileFormat DeserializeDocumentTranslationFileFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string format = default;
            IReadOnlyList<string> fileExtensions = default;
            IReadOnlyList<string> contentTypes = default;
            string defaultVersion = default;
            IReadOnlyList<string> versions = default;
            FileFormatType? type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("format"u8))
                {
                    format = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileExtensions"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fileExtensions = array;
                    continue;
                }
                if (property.NameEquals("contentTypes"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contentTypes = array;
                    continue;
                }
                if (property.NameEquals("defaultVersion"u8))
                {
                    defaultVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("versions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    versions = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new FileFormatType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DocumentTranslationFileFormat(
                format,
                fileExtensions,
                contentTypes,
                defaultVersion,
                versions ?? new ChangeTrackingList<string>(),
                type,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentTranslationFileFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentTranslationFileFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentTranslationFileFormat)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentTranslationFileFormat IPersistableModel<DocumentTranslationFileFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentTranslationFileFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentTranslationFileFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentTranslationFileFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentTranslationFileFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentTranslationFileFormat FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentTranslationFileFormat(document.RootElement);
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
