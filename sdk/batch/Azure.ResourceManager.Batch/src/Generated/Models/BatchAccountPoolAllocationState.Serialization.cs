// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchAccountPoolAllocationStateExtensions
    {
        public static string ToSerialString(this BatchAccountPoolAllocationState value) => value switch
        {
            BatchAccountPoolAllocationState.Steady => "Steady",
            BatchAccountPoolAllocationState.Resizing => "Resizing",
            BatchAccountPoolAllocationState.Stopping => "Stopping",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchAccountPoolAllocationState value.")
        };

        public static BatchAccountPoolAllocationState ToBatchAccountPoolAllocationState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Steady")) return BatchAccountPoolAllocationState.Steady;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Resizing")) return BatchAccountPoolAllocationState.Resizing;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Stopping")) return BatchAccountPoolAllocationState.Stopping;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchAccountPoolAllocationState value.");
        }
    }
}
