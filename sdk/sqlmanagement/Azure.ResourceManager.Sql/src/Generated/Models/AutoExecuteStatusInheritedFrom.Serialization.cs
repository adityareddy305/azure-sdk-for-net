// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class AutoExecuteStatusInheritedFromExtensions
    {
        public static string ToSerialString(this AutoExecuteStatusInheritedFrom value) => value switch
        {
            AutoExecuteStatusInheritedFrom.Default => "Default",
            AutoExecuteStatusInheritedFrom.Subscription => "Subscription",
            AutoExecuteStatusInheritedFrom.Server => "Server",
            AutoExecuteStatusInheritedFrom.ElasticPool => "ElasticPool",
            AutoExecuteStatusInheritedFrom.Database => "Database",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoExecuteStatusInheritedFrom value.")
        };

        public static AutoExecuteStatusInheritedFrom ToAutoExecuteStatusInheritedFrom(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Default")) return AutoExecuteStatusInheritedFrom.Default;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Subscription")) return AutoExecuteStatusInheritedFrom.Subscription;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Server")) return AutoExecuteStatusInheritedFrom.Server;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ElasticPool")) return AutoExecuteStatusInheritedFrom.ElasticPool;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Database")) return AutoExecuteStatusInheritedFrom.Database;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoExecuteStatusInheritedFrom value.");
        }
    }
}
