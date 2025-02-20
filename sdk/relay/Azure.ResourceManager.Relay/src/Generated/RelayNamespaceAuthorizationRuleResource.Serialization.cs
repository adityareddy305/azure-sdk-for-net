// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Relay
{
    public partial class RelayNamespaceAuthorizationRuleResource : IJsonModel<RelayAuthorizationRuleData>
    {
        void IJsonModel<RelayAuthorizationRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RelayAuthorizationRuleData>)Data).Write(writer, options);

        RelayAuthorizationRuleData IJsonModel<RelayAuthorizationRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RelayAuthorizationRuleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RelayAuthorizationRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        RelayAuthorizationRuleData IPersistableModel<RelayAuthorizationRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RelayAuthorizationRuleData>(data, options);

        string IPersistableModel<RelayAuthorizationRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RelayAuthorizationRuleData>)Data).GetFormatFromOptions(options);
    }
}
