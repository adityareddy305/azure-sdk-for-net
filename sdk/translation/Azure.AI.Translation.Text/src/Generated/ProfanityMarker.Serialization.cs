// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Translation.Text
{
    internal static partial class ProfanityMarkerExtensions
    {
        public static string ToSerialString(this ProfanityMarker value) => value switch
        {
            ProfanityMarker.Asterisk => "Asterisk",
            ProfanityMarker.Tag => "Tag",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProfanityMarker value.")
        };

        public static ProfanityMarker ToProfanityMarker(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Asterisk")) return ProfanityMarker.Asterisk;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Tag")) return ProfanityMarker.Tag;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProfanityMarker value.");
        }
    }
}
