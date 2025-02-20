// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Media
{
    public partial class StreamingPolicyResource : IJsonModel<StreamingPolicyData>
    {
        void IJsonModel<StreamingPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StreamingPolicyData>)Data).Write(writer, options);

        StreamingPolicyData IJsonModel<StreamingPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StreamingPolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<StreamingPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        StreamingPolicyData IPersistableModel<StreamingPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StreamingPolicyData>(data, options);

        string IPersistableModel<StreamingPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StreamingPolicyData>)Data).GetFormatFromOptions(options);
    }
}
