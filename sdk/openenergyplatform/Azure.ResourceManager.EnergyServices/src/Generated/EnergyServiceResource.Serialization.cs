// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EnergyServices
{
    public partial class EnergyServiceResource : IJsonModel<EnergyServiceData>
    {
        void IJsonModel<EnergyServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<EnergyServiceData>)Data).Write(writer, options);

        EnergyServiceData IJsonModel<EnergyServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<EnergyServiceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<EnergyServiceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        EnergyServiceData IPersistableModel<EnergyServiceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<EnergyServiceData>(data, options);

        string IPersistableModel<EnergyServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<EnergyServiceData>)Data).GetFormatFromOptions(options);
    }
}
