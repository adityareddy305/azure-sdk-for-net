// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PostgreSql
{
    public partial class PostgreSqlVirtualNetworkRuleResource : IJsonModel<PostgreSqlVirtualNetworkRuleData>
    {
        void IJsonModel<PostgreSqlVirtualNetworkRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlVirtualNetworkRuleData>)Data).Write(writer, options);

        PostgreSqlVirtualNetworkRuleData IJsonModel<PostgreSqlVirtualNetworkRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlVirtualNetworkRuleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PostgreSqlVirtualNetworkRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        PostgreSqlVirtualNetworkRuleData IPersistableModel<PostgreSqlVirtualNetworkRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PostgreSqlVirtualNetworkRuleData>(data, options);

        string IPersistableModel<PostgreSqlVirtualNetworkRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PostgreSqlVirtualNetworkRuleData>)Data).GetFormatFromOptions(options);
    }
}
