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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAzureDataLakeGen1Datastore : IUtf8JsonSerializable, IJsonModel<MachineLearningAzureDataLakeGen1Datastore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAzureDataLakeGen1Datastore>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningAzureDataLakeGen1Datastore>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureDataLakeGen1Datastore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAzureDataLakeGen1Datastore)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("storeName"u8);
            writer.WriteStringValue(StoreName);
            if (Optional.IsDefined(ServiceDataAccessAuthIdentity))
            {
                writer.WritePropertyName("serviceDataAccessAuthIdentity"u8);
                writer.WriteStringValue(ServiceDataAccessAuthIdentity.Value.ToString());
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                if (SubscriptionId != null)
                {
                    writer.WritePropertyName("subscriptionId"u8);
                    writer.WriteStringValue(SubscriptionId);
                }
                else
                {
                    writer.WriteNull("subscriptionId");
                }
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                if (ResourceGroup != null)
                {
                    writer.WritePropertyName("resourceGroup"u8);
                    writer.WriteStringValue(ResourceGroup);
                }
                else
                {
                    writer.WriteNull("resourceGroup");
                }
            }
        }

        MachineLearningAzureDataLakeGen1Datastore IJsonModel<MachineLearningAzureDataLakeGen1Datastore>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureDataLakeGen1Datastore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAzureDataLakeGen1Datastore)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAzureDataLakeGen1Datastore(document.RootElement, options);
        }

        internal static MachineLearningAzureDataLakeGen1Datastore DeserializeMachineLearningAzureDataLakeGen1Datastore(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storeName = default;
            MachineLearningServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity = default;
            string subscriptionId = default;
            string resourceGroup = default;
            DatastoreType datastoreType = default;
            bool? isDefault = default;
            MachineLearningDatastoreCredentials credentials = default;
            string description = default;
            IDictionary<string, string> tags = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storeName"u8))
                {
                    storeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceDataAccessAuthIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceDataAccessAuthIdentity = new MachineLearningServiceDataAccessAuthIdentity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subscriptionId = null;
                        continue;
                    }
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceGroup = null;
                        continue;
                    }
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datastoreType"u8))
                {
                    datastoreType = new DatastoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    credentials = MachineLearningDatastoreCredentials.DeserializeMachineLearningDatastoreCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningAzureDataLakeGen1Datastore(
                description,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                properties ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                datastoreType,
                isDefault,
                credentials,
                storeName,
                serviceDataAccessAuthIdentity,
                subscriptionId,
                resourceGroup);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StoreName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  storeName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StoreName))
                {
                    builder.Append("  storeName: ");
                    if (StoreName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StoreName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StoreName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServiceDataAccessAuthIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serviceDataAccessAuthIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServiceDataAccessAuthIdentity))
                {
                    builder.Append("  serviceDataAccessAuthIdentity: ");
                    builder.AppendLine($"'{ServiceDataAccessAuthIdentity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubscriptionId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subscriptionId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubscriptionId))
                {
                    builder.Append("  subscriptionId: ");
                    if (SubscriptionId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SubscriptionId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SubscriptionId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceGroup), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resourceGroup: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceGroup))
                {
                    builder.Append("  resourceGroup: ");
                    if (ResourceGroup.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ResourceGroup}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ResourceGroup}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatastoreType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  datastoreType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  datastoreType: ");
                builder.AppendLine($"'{DatastoreType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDefault), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isDefault: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDefault))
                {
                    builder.Append("  isDefault: ");
                    var boolValue = IsDefault.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Credentials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  credentials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Credentials))
                {
                    builder.Append("  credentials: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Credentials, options, 2, false, "  credentials: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Properties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  properties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Properties))
                {
                    if (Properties.Any())
                    {
                        builder.Append("  properties: ");
                        builder.AppendLine("{");
                        foreach (var item in Properties)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningAzureDataLakeGen1Datastore>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureDataLakeGen1Datastore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAzureDataLakeGen1Datastore)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningAzureDataLakeGen1Datastore IPersistableModel<MachineLearningAzureDataLakeGen1Datastore>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureDataLakeGen1Datastore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningAzureDataLakeGen1Datastore(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAzureDataLakeGen1Datastore)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningAzureDataLakeGen1Datastore>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
