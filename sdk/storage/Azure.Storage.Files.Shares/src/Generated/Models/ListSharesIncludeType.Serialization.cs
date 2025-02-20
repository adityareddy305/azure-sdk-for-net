// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    internal static partial class ListSharesIncludeTypeExtensions
    {
        public static string ToSerialString(this ListSharesIncludeType value) => value switch
        {
            ListSharesIncludeType.Snapshots => "snapshots",
            ListSharesIncludeType.Metadata => "metadata",
            ListSharesIncludeType.Deleted => "deleted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ListSharesIncludeType value.")
        };

        public static ListSharesIncludeType ToListSharesIncludeType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "snapshots")) return ListSharesIncludeType.Snapshots;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "metadata")) return ListSharesIncludeType.Metadata;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "deleted")) return ListSharesIncludeType.Deleted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ListSharesIncludeType value.");
        }
    }
}
