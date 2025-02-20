// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class GremlinGraphPropertiesConfig : IUtf8JsonSerializable, IJsonModel<GremlinGraphPropertiesConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GremlinGraphPropertiesConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GremlinGraphPropertiesConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GremlinGraphPropertiesConfig)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        GremlinGraphPropertiesConfig IJsonModel<GremlinGraphPropertiesConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GremlinGraphPropertiesConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGremlinGraphPropertiesConfig(document.RootElement, options);
        }

        internal static GremlinGraphPropertiesConfig DeserializeGremlinGraphPropertiesConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? throughput = default;
            AutoscaleSettings autoscaleSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("throughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleSettings = AutoscaleSettings.DeserializeAutoscaleSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GremlinGraphPropertiesConfig(throughput, autoscaleSettings, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Throughput), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  throughput: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Throughput))
                {
                    builder.Append("  throughput: ");
                    builder.AppendLine($"{Throughput.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AutoscaleMaxThroughput", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  autoscaleSettings: ");
                builder.AppendLine("{");
                builder.Append("    maxThroughput: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(AutoscaleSettings))
                {
                    builder.Append("  autoscaleSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AutoscaleSettings, options, 2, false, "  autoscaleSettings: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<GremlinGraphPropertiesConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GremlinGraphPropertiesConfig)} does not support writing '{options.Format}' format.");
            }
        }

        GremlinGraphPropertiesConfig IPersistableModel<GremlinGraphPropertiesConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGremlinGraphPropertiesConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GremlinGraphPropertiesConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GremlinGraphPropertiesConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
