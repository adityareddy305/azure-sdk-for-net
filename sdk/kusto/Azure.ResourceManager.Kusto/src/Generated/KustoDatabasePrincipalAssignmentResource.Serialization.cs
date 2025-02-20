// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Kusto
{
    public partial class KustoDatabasePrincipalAssignmentResource : IJsonModel<KustoDatabasePrincipalAssignmentData>
    {
        void IJsonModel<KustoDatabasePrincipalAssignmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<KustoDatabasePrincipalAssignmentData>)Data).Write(writer, options);

        KustoDatabasePrincipalAssignmentData IJsonModel<KustoDatabasePrincipalAssignmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<KustoDatabasePrincipalAssignmentData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<KustoDatabasePrincipalAssignmentData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        KustoDatabasePrincipalAssignmentData IPersistableModel<KustoDatabasePrincipalAssignmentData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<KustoDatabasePrincipalAssignmentData>(data, options);

        string IPersistableModel<KustoDatabasePrincipalAssignmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<KustoDatabasePrincipalAssignmentData>)Data).GetFormatFromOptions(options);
    }
}
