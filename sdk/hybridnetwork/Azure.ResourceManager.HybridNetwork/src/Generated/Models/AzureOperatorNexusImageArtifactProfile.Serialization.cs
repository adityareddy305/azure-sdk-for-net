// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusImageArtifactProfile : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusImageArtifactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusImageArtifactProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureOperatorNexusImageArtifactProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusImageArtifactProfile)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ImageArtifactProfile))
            {
                writer.WritePropertyName("imageArtifactProfile"u8);
                writer.WriteObjectValue(ImageArtifactProfile, options);
            }
        }

        AzureOperatorNexusImageArtifactProfile IJsonModel<AzureOperatorNexusImageArtifactProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusImageArtifactProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusImageArtifactProfile(document.RootElement, options);
        }

        internal static AzureOperatorNexusImageArtifactProfile DeserializeAzureOperatorNexusImageArtifactProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImageArtifactProfile imageArtifactProfile = default;
            WritableSubResource artifactStore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageArtifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageArtifactProfile = ImageArtifactProfile.DeserializeImageArtifactProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("artifactStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactStore = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureOperatorNexusImageArtifactProfile(artifactStore, serializedAdditionalRawData, imageArtifactProfile);
        }

        BinaryData IPersistableModel<AzureOperatorNexusImageArtifactProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusImageArtifactProfile)} does not support writing '{options.Format}' format.");
            }
        }

        AzureOperatorNexusImageArtifactProfile IPersistableModel<AzureOperatorNexusImageArtifactProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureOperatorNexusImageArtifactProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusImageArtifactProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureOperatorNexusImageArtifactProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
