// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    internal static partial class ShareLeaseStateExtensions
    {
        public static string ToSerialString(this ShareLeaseState value) => value switch
        {
            ShareLeaseState.Available => "available",
            ShareLeaseState.Leased => "leased",
            ShareLeaseState.Expired => "expired",
            ShareLeaseState.Breaking => "breaking",
            ShareLeaseState.Broken => "broken",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ShareLeaseState value.")
        };

        public static ShareLeaseState ToShareLeaseState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "available")) return ShareLeaseState.Available;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "leased")) return ShareLeaseState.Leased;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "expired")) return ShareLeaseState.Expired;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "breaking")) return ShareLeaseState.Breaking;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "broken")) return ShareLeaseState.Broken;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ShareLeaseState value.");
        }
    }
}
