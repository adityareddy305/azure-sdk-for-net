// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseDataConnectionResource : IJsonModel<SynapseDataConnectionData>
    {
        void IJsonModel<SynapseDataConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SynapseDataConnectionData>)Data).Write(writer, options);

        SynapseDataConnectionData IJsonModel<SynapseDataConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SynapseDataConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SynapseDataConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SynapseDataConnectionData IPersistableModel<SynapseDataConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SynapseDataConnectionData>(data, options);

        string IPersistableModel<SynapseDataConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SynapseDataConnectionData>)Data).GetFormatFromOptions(options);
    }
}
