// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class TopLevelDomainResource : IJsonModel<TopLevelDomainData>
    {
        void IJsonModel<TopLevelDomainData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TopLevelDomainData>)Data).Write(writer, options);

        TopLevelDomainData IJsonModel<TopLevelDomainData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TopLevelDomainData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<TopLevelDomainData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        TopLevelDomainData IPersistableModel<TopLevelDomainData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TopLevelDomainData>(data, options);

        string IPersistableModel<TopLevelDomainData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TopLevelDomainData>)Data).GetFormatFromOptions(options);
    }
}
