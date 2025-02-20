// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.OperationalInsights
{
    public partial class LogAnalyticsQueryPackResource : IJsonModel<LogAnalyticsQueryPackData>
    {
        void IJsonModel<LogAnalyticsQueryPackData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LogAnalyticsQueryPackData>)Data).Write(writer, options);

        LogAnalyticsQueryPackData IJsonModel<LogAnalyticsQueryPackData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LogAnalyticsQueryPackData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<LogAnalyticsQueryPackData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        LogAnalyticsQueryPackData IPersistableModel<LogAnalyticsQueryPackData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<LogAnalyticsQueryPackData>(data, options);

        string IPersistableModel<LogAnalyticsQueryPackData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<LogAnalyticsQueryPackData>)Data).GetFormatFromOptions(options);
    }
}
