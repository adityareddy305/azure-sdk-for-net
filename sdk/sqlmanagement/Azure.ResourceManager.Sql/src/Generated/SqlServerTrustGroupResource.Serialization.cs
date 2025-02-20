// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerTrustGroupResource : IJsonModel<SqlServerTrustGroupData>
    {
        void IJsonModel<SqlServerTrustGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerTrustGroupData>)Data).Write(writer, options);

        SqlServerTrustGroupData IJsonModel<SqlServerTrustGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerTrustGroupData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SqlServerTrustGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SqlServerTrustGroupData IPersistableModel<SqlServerTrustGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlServerTrustGroupData>(data, options);

        string IPersistableModel<SqlServerTrustGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlServerTrustGroupData>)Data).GetFormatFromOptions(options);
    }
}
