// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningBatchDeploymentResource : IJsonModel<MachineLearningBatchDeploymentData>
    {
        void IJsonModel<MachineLearningBatchDeploymentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningBatchDeploymentData>)Data).Write(writer, options);

        MachineLearningBatchDeploymentData IJsonModel<MachineLearningBatchDeploymentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningBatchDeploymentData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningBatchDeploymentData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MachineLearningBatchDeploymentData IPersistableModel<MachineLearningBatchDeploymentData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningBatchDeploymentData>(data, options);

        string IPersistableModel<MachineLearningBatchDeploymentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningBatchDeploymentData>)Data).GetFormatFromOptions(options);
    }
}
