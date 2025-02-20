// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class SensitivityLabelSourceExtensions
    {
        public static string ToSerialString(this SensitivityLabelSource value) => value switch
        {
            SensitivityLabelSource.Current => "current",
            SensitivityLabelSource.Recommended => "recommended",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SensitivityLabelSource value.")
        };

        public static SensitivityLabelSource ToSensitivityLabelSource(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "current")) return SensitivityLabelSource.Current;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "recommended")) return SensitivityLabelSource.Recommended;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SensitivityLabelSource value.");
        }
    }
}
