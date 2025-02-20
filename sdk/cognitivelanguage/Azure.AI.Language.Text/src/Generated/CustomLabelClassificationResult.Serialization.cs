// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    public partial class CustomLabelClassificationResult : IUtf8JsonSerializable, IJsonModel<CustomLabelClassificationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomLabelClassificationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomLabelClassificationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLabelClassificationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomLabelClassificationResult)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("errors"u8);
            writer.WriteStartArray();
            foreach (var item in Errors)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics, options);
            }
            writer.WritePropertyName("projectName"u8);
            writer.WriteStringValue(ProjectName);
            writer.WritePropertyName("deploymentName"u8);
            writer.WriteStringValue(DeploymentName);
            writer.WritePropertyName("documents"u8);
            writer.WriteStartArray();
            foreach (var item in Documents)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        CustomLabelClassificationResult IJsonModel<CustomLabelClassificationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLabelClassificationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomLabelClassificationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomLabelClassificationResult(document.RootElement, options);
        }

        internal static CustomLabelClassificationResult DeserializeCustomLabelClassificationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DocumentError> errors = default;
            RequestStatistics statistics = default;
            string projectName = default;
            string deploymentName = default;
            IReadOnlyList<ClassificationActionResult> documents = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"u8))
                {
                    List<DocumentError> array = new List<DocumentError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentError.DeserializeDocumentError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = RequestStatistics.DeserializeRequestStatistics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentName"u8))
                {
                    deploymentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documents"u8))
                {
                    List<ClassificationActionResult> array = new List<ClassificationActionResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClassificationActionResult.DeserializeClassificationActionResult(item, options));
                    }
                    documents = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomLabelClassificationResult(
                errors,
                statistics,
                projectName,
                deploymentName,
                documents,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomLabelClassificationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLabelClassificationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomLabelClassificationResult)} does not support writing '{options.Format}' format.");
            }
        }

        CustomLabelClassificationResult IPersistableModel<CustomLabelClassificationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLabelClassificationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomLabelClassificationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomLabelClassificationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomLabelClassificationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CustomLabelClassificationResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCustomLabelClassificationResult(document.RootElement);
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
