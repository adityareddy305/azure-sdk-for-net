// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Advisor
{
    public partial class ResourceRecommendationBaseResource : IJsonModel<ResourceRecommendationBaseData>
    {
        void IJsonModel<ResourceRecommendationBaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ResourceRecommendationBaseData>)Data).Write(writer, options);

        ResourceRecommendationBaseData IJsonModel<ResourceRecommendationBaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ResourceRecommendationBaseData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ResourceRecommendationBaseData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ResourceRecommendationBaseData IPersistableModel<ResourceRecommendationBaseData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ResourceRecommendationBaseData>(data, options);

        string IPersistableModel<ResourceRecommendationBaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ResourceRecommendationBaseData>)Data).GetFormatFromOptions(options);
    }
}
