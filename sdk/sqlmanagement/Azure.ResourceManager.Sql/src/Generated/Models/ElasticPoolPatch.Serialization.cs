// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolPatch : IUtf8JsonSerializable, IJsonModel<ElasticPoolPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticPoolPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ElasticPoolPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolPatch)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxSizeBytes))
            {
                writer.WritePropertyName("maxSizeBytes"u8);
                writer.WriteNumberValue(MaxSizeBytes.Value);
            }
            if (Optional.IsDefined(MinCapacity))
            {
                writer.WritePropertyName("minCapacity"u8);
                writer.WriteNumberValue(MinCapacity.Value);
            }
            if (Optional.IsDefined(PerDatabaseSettings))
            {
                writer.WritePropertyName("perDatabaseSettings"u8);
                writer.WriteObjectValue(PerDatabaseSettings, options);
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId"u8);
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(HighAvailabilityReplicaCount))
            {
                writer.WritePropertyName("highAvailabilityReplicaCount"u8);
                writer.WriteNumberValue(HighAvailabilityReplicaCount.Value);
            }
            if (Optional.IsDefined(PreferredEnclaveType))
            {
                writer.WritePropertyName("preferredEnclaveType"u8);
                writer.WriteStringValue(PreferredEnclaveType.Value.ToString());
            }
            if (Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone.Value.ToString());
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

        ElasticPoolPatch IJsonModel<ElasticPoolPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticPoolPatch(document.RootElement, options);
        }

        internal static ElasticPoolPatch DeserializeElasticPoolPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlSku sku = default;
            IDictionary<string, string> tags = default;
            long? maxSizeBytes = default;
            double? minCapacity = default;
            ElasticPoolPerDatabaseSettings perDatabaseSettings = default;
            bool? zoneRedundant = default;
            ElasticPoolLicenseType? licenseType = default;
            ResourceIdentifier maintenanceConfigurationId = default;
            int? highAvailabilityReplicaCount = default;
            SqlAlwaysEncryptedEnclaveType? preferredEnclaveType = default;
            SqlAvailabilityZoneType? availabilityZone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value, options);
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("maxSizeBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("minCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minCapacity = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("perDatabaseSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            perDatabaseSettings = ElasticPoolPerDatabaseSettings.DeserializeElasticPoolPerDatabaseSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseType = new ElasticPoolLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maintenanceConfigurationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceConfigurationId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("highAvailabilityReplicaCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            highAvailabilityReplicaCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("preferredEnclaveType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredEnclaveType = new SqlAlwaysEncryptedEnclaveType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityZone = new SqlAvailabilityZoneType(property0.Value.GetString());
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
            return new ElasticPoolPatch(
                sku,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                maxSizeBytes,
                minCapacity,
                perDatabaseSettings,
                zoneRedundant,
                licenseType,
                maintenanceConfigurationId,
                highAvailabilityReplicaCount,
                preferredEnclaveType,
                availabilityZone,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticPoolPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolPatch)} does not support writing '{options.Format}' format.");
            }
        }

        ElasticPoolPatch IPersistableModel<ElasticPoolPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticPoolPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticPoolPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
