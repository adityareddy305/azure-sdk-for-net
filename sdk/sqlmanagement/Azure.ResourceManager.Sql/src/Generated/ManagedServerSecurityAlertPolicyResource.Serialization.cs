// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedServerSecurityAlertPolicyResource : IJsonModel<ManagedServerSecurityAlertPolicyData>
    {
        void IJsonModel<ManagedServerSecurityAlertPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ManagedServerSecurityAlertPolicyData>)Data).Write(writer, options);

        ManagedServerSecurityAlertPolicyData IJsonModel<ManagedServerSecurityAlertPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ManagedServerSecurityAlertPolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ManagedServerSecurityAlertPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ManagedServerSecurityAlertPolicyData IPersistableModel<ManagedServerSecurityAlertPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ManagedServerSecurityAlertPolicyData>(data, options);

        string IPersistableModel<ManagedServerSecurityAlertPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ManagedServerSecurityAlertPolicyData>)Data).GetFormatFromOptions(options);
    }
}
