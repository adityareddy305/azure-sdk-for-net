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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class ProcessModuleInfoData : IUtf8JsonSerializable, IJsonModel<ProcessModuleInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProcessModuleInfoData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProcessModuleInfoData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessModuleInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcessModuleInfoData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseAddress))
            {
                writer.WritePropertyName("base_address"u8);
                writer.WriteStringValue(BaseAddress);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("file_name"u8);
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(Href))
            {
                writer.WritePropertyName("href"u8);
                writer.WriteStringValue(Href);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("file_path"u8);
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(ModuleMemorySize))
            {
                writer.WritePropertyName("module_memory_size"u8);
                writer.WriteNumberValue(ModuleMemorySize.Value);
            }
            if (Optional.IsDefined(FileVersion))
            {
                writer.WritePropertyName("file_version"u8);
                writer.WriteStringValue(FileVersion);
            }
            if (Optional.IsDefined(FileDescription))
            {
                writer.WritePropertyName("file_description"u8);
                writer.WriteStringValue(FileDescription);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(ProductVersion))
            {
                writer.WritePropertyName("product_version"u8);
                writer.WriteStringValue(ProductVersion);
            }
            if (Optional.IsDefined(IsDebug))
            {
                writer.WritePropertyName("is_debug"u8);
                writer.WriteBooleanValue(IsDebug.Value);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            writer.WriteEndObject();
        }

        ProcessModuleInfoData IJsonModel<ProcessModuleInfoData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessModuleInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcessModuleInfoData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProcessModuleInfoData(document.RootElement, options);
        }

        internal static ProcessModuleInfoData DeserializeProcessModuleInfoData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string baseAddress = default;
            string fileName = default;
            string href = default;
            string filePath = default;
            int? moduleMemorySize = default;
            string fileVersion = default;
            string fileDescription = default;
            string product = default;
            string productVersion = default;
            bool? isDebug = default;
            string language = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("base_address"u8))
                        {
                            baseAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("file_name"u8))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("href"u8))
                        {
                            href = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("file_path"u8))
                        {
                            filePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("module_memory_size"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            moduleMemorySize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("file_version"u8))
                        {
                            fileVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("file_description"u8))
                        {
                            fileDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product_version"u8))
                        {
                            productVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("is_debug"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDebug = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("language"u8))
                        {
                            language = property0.Value.GetString();
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
            return new ProcessModuleInfoData(
                id,
                name,
                type,
                systemData,
                baseAddress,
                fileName,
                href,
                filePath,
                moduleMemorySize,
                fileVersion,
                fileDescription,
                product,
                productVersion,
                isDebug,
                language,
                kind,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BaseAddress), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    base_address: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BaseAddress))
                {
                    builder.Append("    base_address: ");
                    if (BaseAddress.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BaseAddress}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BaseAddress}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FileName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    file_name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FileName))
                {
                    builder.Append("    file_name: ");
                    if (FileName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FileName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FileName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Href), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    href: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Href))
                {
                    builder.Append("    href: ");
                    if (Href.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Href}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Href}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FilePath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    file_path: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FilePath))
                {
                    builder.Append("    file_path: ");
                    if (FilePath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FilePath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FilePath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ModuleMemorySize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    module_memory_size: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ModuleMemorySize))
                {
                    builder.Append("    module_memory_size: ");
                    builder.AppendLine($"{ModuleMemorySize.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FileVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    file_version: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FileVersion))
                {
                    builder.Append("    file_version: ");
                    if (FileVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FileVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FileVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FileDescription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    file_description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FileDescription))
                {
                    builder.Append("    file_description: ");
                    if (FileDescription.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FileDescription}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FileDescription}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Product), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    product: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Product))
                {
                    builder.Append("    product: ");
                    if (Product.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Product}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Product}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProductVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    product_version: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProductVersion))
                {
                    builder.Append("    product_version: ");
                    if (ProductVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProductVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProductVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDebug), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    is_debug: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDebug))
                {
                    builder.Append("    is_debug: ");
                    var boolValue = IsDebug.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Language), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    language: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Language))
                {
                    builder.Append("    language: ");
                    if (Language.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Language}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Language}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ProcessModuleInfoData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessModuleInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ProcessModuleInfoData)} does not support writing '{options.Format}' format.");
            }
        }

        ProcessModuleInfoData IPersistableModel<ProcessModuleInfoData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessModuleInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProcessModuleInfoData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProcessModuleInfoData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProcessModuleInfoData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
