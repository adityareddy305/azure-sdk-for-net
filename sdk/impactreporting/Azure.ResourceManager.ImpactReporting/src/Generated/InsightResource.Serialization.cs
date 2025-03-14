// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ImpactReporting
{
    public partial class InsightResource : IJsonModel<InsightData>
    {
        void IJsonModel<InsightData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<InsightData>)Data).Write(writer, options);

        InsightData IJsonModel<InsightData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<InsightData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<InsightData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        InsightData IPersistableModel<InsightData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<InsightData>(data, options);

        string IPersistableModel<InsightData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<InsightData>)Data).GetFormatFromOptions(options);
    }
}
