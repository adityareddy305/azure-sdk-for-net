// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridNetwork
{
    public partial class SiteResource : IJsonModel<SiteData>
    {
        void IJsonModel<SiteData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SiteData>)Data).Write(writer, options);

        SiteData IJsonModel<SiteData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SiteData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SiteData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SiteData IPersistableModel<SiteData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SiteData>(data, options);

        string IPersistableModel<SiteData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SiteData>)Data).GetFormatFromOptions(options);
    }
}
