// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityHealthReportResource : IJsonModel<SecurityHealthReportData>
    {
        void IJsonModel<SecurityHealthReportData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityHealthReportData>)Data).Write(writer, options);

        SecurityHealthReportData IJsonModel<SecurityHealthReportData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityHealthReportData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityHealthReportData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityHealthReportData IPersistableModel<SecurityHealthReportData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityHealthReportData>(data, options);

        string IPersistableModel<SecurityHealthReportData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityHealthReportData>)Data).GetFormatFromOptions(options);
    }
}
