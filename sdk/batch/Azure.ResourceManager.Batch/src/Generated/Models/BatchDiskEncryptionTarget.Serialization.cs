// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchDiskEncryptionTargetExtensions
    {
        public static string ToSerialString(this BatchDiskEncryptionTarget value) => value switch
        {
            BatchDiskEncryptionTarget.OSDisk => "OsDisk",
            BatchDiskEncryptionTarget.TemporaryDisk => "TemporaryDisk",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchDiskEncryptionTarget value.")
        };

        public static BatchDiskEncryptionTarget ToBatchDiskEncryptionTarget(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "OsDisk")) return BatchDiskEncryptionTarget.OSDisk;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "TemporaryDisk")) return BatchDiskEncryptionTarget.TemporaryDisk;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchDiskEncryptionTarget value.");
        }
    }
}
