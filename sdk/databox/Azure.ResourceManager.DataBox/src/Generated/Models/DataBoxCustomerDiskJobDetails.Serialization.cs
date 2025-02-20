// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxCustomerDiskJobDetails : IUtf8JsonSerializable, IJsonModel<DataBoxCustomerDiskJobDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxCustomerDiskJobDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxCustomerDiskJobDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxCustomerDiskJobDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(ImportDiskDetails))
            {
                writer.WritePropertyName("importDiskDetailsCollection"u8);
                writer.WriteStartObject();
                foreach (var item in ImportDiskDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExportDiskDetails))
            {
                writer.WritePropertyName("exportDiskDetailsCollection"u8);
                writer.WriteStartObject();
                foreach (var item in ExportDiskDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(CopyProgress))
            {
                writer.WritePropertyName("copyProgress"u8);
                writer.WriteStartArray();
                foreach (var item in CopyProgress)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DeliverToDataCenterPackageDetails))
            {
                writer.WritePropertyName("deliverToDcPackageDetails"u8);
                writer.WriteObjectValue(DeliverToDataCenterPackageDetails, options);
            }
            writer.WritePropertyName("returnToCustomerPackageDetails"u8);
            writer.WriteObjectValue(ReturnToCustomerPackageDetails, options);
            if (Optional.IsDefined(EnableManifestBackup))
            {
                writer.WritePropertyName("enableManifestBackup"u8);
                writer.WriteBooleanValue(EnableManifestBackup.Value);
            }
        }

        DataBoxCustomerDiskJobDetails IJsonModel<DataBoxCustomerDiskJobDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxCustomerDiskJobDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxCustomerDiskJobDetails(document.RootElement, options);
        }

        internal static DataBoxCustomerDiskJobDetails DeserializeDataBoxCustomerDiskJobDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, ImportDiskDetails> importDiskDetailsCollection = default;
            IReadOnlyDictionary<string, ExportDiskDetails> exportDiskDetailsCollection = default;
            IReadOnlyList<DataBoxCustomerDiskCopyProgress> copyProgress = default;
            PackageCarrierInfo deliverToDcPackageDetails = default;
            PackageCarrierDetails returnToCustomerPackageDetails = default;
            bool? enableManifestBackup = default;
            IReadOnlyList<DataBoxJobStage> jobStages = default;
            DataBoxContactDetails contactDetails = default;
            DataBoxShippingAddress shippingAddress = default;
            PackageShippingDetails deliveryPackage = default;
            PackageShippingDetails returnPackage = default;
            IList<DataImportDetails> dataImportDetails = default;
            IList<DataExportDetails> dataExportDetails = default;
            DataBoxOrderType jobDetailsType = default;
            DataBoxOrderPreferences preferences = default;
            ReverseShippingDetails reverseShippingDetails = default;
            IReadOnlyList<CopyLogDetails> copyLogDetails = default;
            string reverseShipmentLabelSasKey = default;
            string chainOfCustodySasKey = default;
            DeviceErasureDetails deviceErasureDetails = default;
            DataBoxKeyEncryptionKey keyEncryptionKey = default;
            int? expectedDataSizeInTerabytes = default;
            IReadOnlyList<CustomerResolutionCode> actions = default;
            LastMitigationActionOnJob lastMitigationActionOnJob = default;
            DataCenterAddressResult dataCenterAddress = default;
            DataCenterCode? dataCenterCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("importDiskDetailsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ImportDiskDetails> dictionary = new Dictionary<string, ImportDiskDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.ImportDiskDetails.DeserializeImportDiskDetails(property0.Value, options));
                    }
                    importDiskDetailsCollection = dictionary;
                    continue;
                }
                if (property.NameEquals("exportDiskDetailsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ExportDiskDetails> dictionary = new Dictionary<string, ExportDiskDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.ExportDiskDetails.DeserializeExportDiskDetails(property0.Value, options));
                    }
                    exportDiskDetailsCollection = dictionary;
                    continue;
                }
                if (property.NameEquals("copyProgress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxCustomerDiskCopyProgress> array = new List<DataBoxCustomerDiskCopyProgress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxCustomerDiskCopyProgress.DeserializeDataBoxCustomerDiskCopyProgress(item, options));
                    }
                    copyProgress = array;
                    continue;
                }
                if (property.NameEquals("deliverToDcPackageDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliverToDcPackageDetails = PackageCarrierInfo.DeserializePackageCarrierInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("returnToCustomerPackageDetails"u8))
                {
                    returnToCustomerPackageDetails = PackageCarrierDetails.DeserializePackageCarrierDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enableManifestBackup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableManifestBackup = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobStages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxJobStage> array = new List<DataBoxJobStage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxJobStage.DeserializeDataBoxJobStage(item, options));
                    }
                    jobStages = array;
                    continue;
                }
                if (property.NameEquals("contactDetails"u8))
                {
                    contactDetails = DataBoxContactDetails.DeserializeDataBoxContactDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("shippingAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingAddress = DataBoxShippingAddress.DeserializeDataBoxShippingAddress(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deliveryPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("returnPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataImportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataImportDetails> array = new List<DataImportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataImportDetails.DeserializeDataImportDetails(item, options));
                    }
                    dataImportDetails = array;
                    continue;
                }
                if (property.NameEquals("dataExportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataExportDetails> array = new List<DataExportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataExportDetails.DeserializeDataExportDetails(item, options));
                    }
                    dataExportDetails = array;
                    continue;
                }
                if (property.NameEquals("jobDetailsType"u8))
                {
                    jobDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("preferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferences = DataBoxOrderPreferences.DeserializeDataBoxOrderPreferences(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reverseShippingDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseShippingDetails = ReverseShippingDetails.DeserializeReverseShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("copyLogDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CopyLogDetails> array = new List<CopyLogDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.CopyLogDetails.DeserializeCopyLogDetails(item, options));
                    }
                    copyLogDetails = array;
                    continue;
                }
                if (property.NameEquals("reverseShipmentLabelSasKey"u8))
                {
                    reverseShipmentLabelSasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chainOfCustodySasKey"u8))
                {
                    chainOfCustodySasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceErasureDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceErasureDetails = DeviceErasureDetails.DeserializeDeviceErasureDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = DataBoxKeyEncryptionKey.DeserializeDataBoxKeyEncryptionKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("expectedDataSizeInTeraBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expectedDataSizeInTerabytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerResolutionCode> array = new List<CustomerResolutionCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCustomerResolutionCode());
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("lastMitigationActionOnJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastMitigationActionOnJob = LastMitigationActionOnJob.DeserializeLastMitigationActionOnJob(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datacenterAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAddress = DataCenterAddressResult.DeserializeDataCenterAddressResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataCenterCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterCode = new DataCenterCode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxCustomerDiskJobDetails(
                jobStages ?? new ChangeTrackingList<DataBoxJobStage>(),
                contactDetails,
                shippingAddress,
                deliveryPackage,
                returnPackage,
                dataImportDetails ?? new ChangeTrackingList<DataImportDetails>(),
                dataExportDetails ?? new ChangeTrackingList<DataExportDetails>(),
                jobDetailsType,
                preferences,
                reverseShippingDetails,
                copyLogDetails ?? new ChangeTrackingList<CopyLogDetails>(),
                reverseShipmentLabelSasKey,
                chainOfCustodySasKey,
                deviceErasureDetails,
                keyEncryptionKey,
                expectedDataSizeInTerabytes,
                actions ?? new ChangeTrackingList<CustomerResolutionCode>(),
                lastMitigationActionOnJob,
                dataCenterAddress,
                dataCenterCode,
                serializedAdditionalRawData,
                importDiskDetailsCollection ?? new ChangeTrackingDictionary<string, ImportDiskDetails>(),
                exportDiskDetailsCollection ?? new ChangeTrackingDictionary<string, ExportDiskDetails>(),
                copyProgress ?? new ChangeTrackingList<DataBoxCustomerDiskCopyProgress>(),
                deliverToDcPackageDetails,
                returnToCustomerPackageDetails,
                enableManifestBackup);
        }

        BinaryData IPersistableModel<DataBoxCustomerDiskJobDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxCustomerDiskJobDetails)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxCustomerDiskJobDetails IPersistableModel<DataBoxCustomerDiskJobDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxCustomerDiskJobDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxCustomerDiskJobDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxCustomerDiskJobDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
