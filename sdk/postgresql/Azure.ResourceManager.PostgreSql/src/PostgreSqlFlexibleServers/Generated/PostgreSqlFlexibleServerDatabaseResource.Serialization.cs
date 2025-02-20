// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    public partial class PostgreSqlFlexibleServerDatabaseResource : IJsonModel<PostgreSqlFlexibleServerDatabaseData>
    {
        void IJsonModel<PostgreSqlFlexibleServerDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlFlexibleServerDatabaseData>)Data).Write(writer, options);

        PostgreSqlFlexibleServerDatabaseData IJsonModel<PostgreSqlFlexibleServerDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlFlexibleServerDatabaseData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PostgreSqlFlexibleServerDatabaseData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        PostgreSqlFlexibleServerDatabaseData IPersistableModel<PostgreSqlFlexibleServerDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PostgreSqlFlexibleServerDatabaseData>(data, options);

        string IPersistableModel<PostgreSqlFlexibleServerDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PostgreSqlFlexibleServerDatabaseData>)Data).GetFormatFromOptions(options);
    }
}
