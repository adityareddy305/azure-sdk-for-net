// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer.Training;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class TrainResult
    {
        internal static TrainResult DeserializeTrainResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<TrainingDocumentInfo> trainingDocuments = default;
            IReadOnlyList<CustomFormModelField> fields = default;
            float? averageModelAccuracy = default;
            string modelId = default;
            IReadOnlyList<FormRecognizerError> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trainingDocuments"u8))
                {
                    List<TrainingDocumentInfo> array = new List<TrainingDocumentInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrainingDocumentInfo.DeserializeTrainingDocumentInfo(item));
                    }
                    trainingDocuments = array;
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomFormModelField> array = new List<CustomFormModelField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomFormModelField.DeserializeCustomFormModelField(item));
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("averageModelAccuracy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    averageModelAccuracy = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FormRecognizerError> array = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new TrainResult(trainingDocuments, fields ?? new ChangeTrackingList<CustomFormModelField>(), averageModelAccuracy, modelId, errors ?? new ChangeTrackingList<FormRecognizerError>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TrainResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTrainResult(document.RootElement);
        }
    }
}
