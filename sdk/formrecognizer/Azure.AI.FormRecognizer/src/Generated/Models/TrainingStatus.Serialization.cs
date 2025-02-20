// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Training
{
    internal static partial class TrainingStatusExtensions
    {
        public static string ToSerialString(this TrainingStatus value) => value switch
        {
            TrainingStatus.Succeeded => "succeeded",
            TrainingStatus.PartiallySucceeded => "partiallySucceeded",
            TrainingStatus.Failed => "failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TrainingStatus value.")
        };

        public static TrainingStatus ToTrainingStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "succeeded")) return TrainingStatus.Succeeded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "partiallySucceeded")) return TrainingStatus.PartiallySucceeded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "failed")) return TrainingStatus.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TrainingStatus value.");
        }
    }
}
