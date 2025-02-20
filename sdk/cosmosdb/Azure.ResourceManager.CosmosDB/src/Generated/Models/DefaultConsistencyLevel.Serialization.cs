// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal static partial class DefaultConsistencyLevelExtensions
    {
        public static string ToSerialString(this DefaultConsistencyLevel value) => value switch
        {
            DefaultConsistencyLevel.Eventual => "Eventual",
            DefaultConsistencyLevel.Session => "Session",
            DefaultConsistencyLevel.BoundedStaleness => "BoundedStaleness",
            DefaultConsistencyLevel.Strong => "Strong",
            DefaultConsistencyLevel.ConsistentPrefix => "ConsistentPrefix",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DefaultConsistencyLevel value.")
        };

        public static DefaultConsistencyLevel ToDefaultConsistencyLevel(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Eventual")) return DefaultConsistencyLevel.Eventual;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Session")) return DefaultConsistencyLevel.Session;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "BoundedStaleness")) return DefaultConsistencyLevel.BoundedStaleness;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Strong")) return DefaultConsistencyLevel.Strong;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ConsistentPrefix")) return DefaultConsistencyLevel.ConsistentPrefix;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DefaultConsistencyLevel value.");
        }
    }
}
