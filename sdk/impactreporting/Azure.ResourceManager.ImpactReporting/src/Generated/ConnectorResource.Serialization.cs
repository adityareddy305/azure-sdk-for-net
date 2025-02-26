// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ImpactReporting
{
    public partial class ConnectorResource : IJsonModel<ConnectorData>
    {
        void IJsonModel<ConnectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ConnectorData>)Data).Write(writer, options);

        ConnectorData IJsonModel<ConnectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ConnectorData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ConnectorData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ConnectorData IPersistableModel<ConnectorData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ConnectorData>(data, options);

        string IPersistableModel<ConnectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ConnectorData>)Data).GetFormatFromOptions(options);
    }
}
