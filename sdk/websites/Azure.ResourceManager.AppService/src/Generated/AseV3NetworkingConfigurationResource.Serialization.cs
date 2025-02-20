// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class AseV3NetworkingConfigurationResource : IJsonModel<AseV3NetworkingConfigurationData>
    {
        void IJsonModel<AseV3NetworkingConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AseV3NetworkingConfigurationData>)Data).Write(writer, options);

        AseV3NetworkingConfigurationData IJsonModel<AseV3NetworkingConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AseV3NetworkingConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AseV3NetworkingConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AseV3NetworkingConfigurationData IPersistableModel<AseV3NetworkingConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AseV3NetworkingConfigurationData>(data, options);

        string IPersistableModel<AseV3NetworkingConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AseV3NetworkingConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
