// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusPrivateLinkResource : IUtf8JsonSerializable, IJsonModel<ServiceBusPrivateLinkResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusPrivateLinkResource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceBusPrivateLinkResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusPrivateLinkResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusPrivateLinkResource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsCollectionDefined(RequiredMembers))
            {
                writer.WritePropertyName("requiredMembers"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredMembers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RequiredZoneNames))
            {
                writer.WritePropertyName("requiredZoneNames"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredZoneNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        ServiceBusPrivateLinkResource IJsonModel<ServiceBusPrivateLinkResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusPrivateLinkResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusPrivateLinkResource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusPrivateLinkResource(document.RootElement, options);
        }

        internal static ServiceBusPrivateLinkResource DeserializeServiceBusPrivateLinkResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string groupId = default;
            IReadOnlyList<string> requiredMembers = default;
            IReadOnlyList<string> requiredZoneNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("groupId"u8))
                        {
                            groupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredMembers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            requiredMembers = array;
                            continue;
                        }
                        if (property0.NameEquals("requiredZoneNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            requiredZoneNames = array;
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
            return new ServiceBusPrivateLinkResource(
                id,
                name,
                type,
                systemData,
                groupId,
                requiredMembers ?? new ChangeTrackingList<string>(),
                requiredZoneNames ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GroupId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    groupId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GroupId))
                {
                    builder.Append("    groupId: ");
                    if (GroupId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GroupId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GroupId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequiredMembers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    requiredMembers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(RequiredMembers))
                {
                    if (RequiredMembers.Any())
                    {
                        builder.Append("    requiredMembers: ");
                        builder.AppendLine("[");
                        foreach (var item in RequiredMembers)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequiredZoneNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    requiredZoneNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(RequiredZoneNames))
                {
                    if (RequiredZoneNames.Any())
                    {
                        builder.Append("    requiredZoneNames: ");
                        builder.AppendLine("[");
                        foreach (var item in RequiredZoneNames)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ServiceBusPrivateLinkResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusPrivateLinkResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusPrivateLinkResource)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceBusPrivateLinkResource IPersistableModel<ServiceBusPrivateLinkResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusPrivateLinkResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusPrivateLinkResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceBusPrivateLinkResource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusPrivateLinkResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
