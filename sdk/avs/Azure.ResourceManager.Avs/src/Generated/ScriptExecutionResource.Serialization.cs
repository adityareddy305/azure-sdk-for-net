// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs
{
    public partial class ScriptExecutionResource : IJsonModel<ScriptExecutionData>
    {
        void IJsonModel<ScriptExecutionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ScriptExecutionData>)Data).Write(writer, options);

        ScriptExecutionData IJsonModel<ScriptExecutionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ScriptExecutionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ScriptExecutionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ScriptExecutionData IPersistableModel<ScriptExecutionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ScriptExecutionData>(data, options);

        string IPersistableModel<ScriptExecutionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ScriptExecutionData>)Data).GetFormatFromOptions(options);
    }
}
