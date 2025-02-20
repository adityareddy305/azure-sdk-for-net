// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class ScopeConnectionResource : IJsonModel<ScopeConnectionData>
    {
        void IJsonModel<ScopeConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ScopeConnectionData>)Data).Write(writer, options);

        ScopeConnectionData IJsonModel<ScopeConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ScopeConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ScopeConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ScopeConnectionData IPersistableModel<ScopeConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ScopeConnectionData>(data, options);

        string IPersistableModel<ScopeConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ScopeConnectionData>)Data).GetFormatFromOptions(options);
    }
}
