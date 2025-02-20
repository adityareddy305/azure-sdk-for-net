// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class SslCertAssetResource : IUtf8JsonSerializable, IJsonModel<SslCertAssetResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SslCertAssetResource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SslCertAssetResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SslCertAssetResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SslCertAssetResource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("asset"u8);
            writer.WriteObjectValue(Asset, options);
        }

        SslCertAssetResource IJsonModel<SslCertAssetResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SslCertAssetResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SslCertAssetResource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSslCertAssetResource(document.RootElement, options);
        }

        internal static SslCertAssetResource DeserializeSslCertAssetResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SslCertAsset asset = default;
            string kind = default;
            string id = default;
            string name = default;
            string displayName = default;
            Guid? uuid = default;
            DateTimeOffset? createdDate = default;
            DateTimeOffset? updatedDate = default;
            AssetState? state = default;
            string externalId = default;
            IReadOnlyList<string> labels = default;
            bool? wildcard = default;
            string discoGroupName = default;
            IReadOnlyList<AuditTrailItem> auditTrail = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("asset"u8))
                {
                    asset = SslCertAsset.DeserializeSslCertAsset(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("createdDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new AssetState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("externalId"u8))
                {
                    externalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
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
                    labels = array;
                    continue;
                }
                if (property.NameEquals("wildcard"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcard = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("discoGroupName"u8))
                {
                    discoGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("auditTrail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AuditTrailItem> array = new List<AuditTrailItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuditTrailItem.DeserializeAuditTrailItem(item, options));
                    }
                    auditTrail = array;
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SslCertAssetResource(
                kind,
                id,
                name,
                displayName,
                uuid,
                createdDate,
                updatedDate,
                state,
                externalId,
                labels ?? new ChangeTrackingList<string>(),
                wildcard,
                discoGroupName,
                auditTrail ?? new ChangeTrackingList<AuditTrailItem>(),
                reason,
                serializedAdditionalRawData,
                asset);
        }

        BinaryData IPersistableModel<SslCertAssetResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SslCertAssetResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SslCertAssetResource)} does not support writing '{options.Format}' format.");
            }
        }

        SslCertAssetResource IPersistableModel<SslCertAssetResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SslCertAssetResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSslCertAssetResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SslCertAssetResource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SslCertAssetResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new SslCertAssetResource FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSslCertAssetResource(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
