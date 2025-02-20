// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceFabric
{
    public partial class ServiceFabricApplicationResource : IJsonModel<ServiceFabricApplicationData>
    {
        void IJsonModel<ServiceFabricApplicationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ServiceFabricApplicationData>)Data).Write(writer, options);

        ServiceFabricApplicationData IJsonModel<ServiceFabricApplicationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ServiceFabricApplicationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ServiceFabricApplicationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ServiceFabricApplicationData IPersistableModel<ServiceFabricApplicationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ServiceFabricApplicationData>(data, options);

        string IPersistableModel<ServiceFabricApplicationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ServiceFabricApplicationData>)Data).GetFormatFromOptions(options);
    }
}
