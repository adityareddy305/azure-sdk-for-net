// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class ConnectionStringTypeExtensions
    {
        public static string ToSerialString(this ConnectionStringType value) => value switch
        {
            ConnectionStringType.MySql => "MySql",
            ConnectionStringType.SqlServer => "SQLServer",
            ConnectionStringType.SqlAzure => "SQLAzure",
            ConnectionStringType.Custom => "Custom",
            ConnectionStringType.NotificationHub => "NotificationHub",
            ConnectionStringType.ServiceBus => "ServiceBus",
            ConnectionStringType.EventHub => "EventHub",
            ConnectionStringType.ApiHub => "ApiHub",
            ConnectionStringType.DocDB => "DocDb",
            ConnectionStringType.RedisCache => "RedisCache",
            ConnectionStringType.PostgreSql => "PostgreSQL",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ConnectionStringType value.")
        };

        public static ConnectionStringType ToConnectionStringType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MySql")) return ConnectionStringType.MySql;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SQLServer")) return ConnectionStringType.SqlServer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SQLAzure")) return ConnectionStringType.SqlAzure;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Custom")) return ConnectionStringType.Custom;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotificationHub")) return ConnectionStringType.NotificationHub;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ServiceBus")) return ConnectionStringType.ServiceBus;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "EventHub")) return ConnectionStringType.EventHub;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ApiHub")) return ConnectionStringType.ApiHub;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "DocDb")) return ConnectionStringType.DocDB;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "RedisCache")) return ConnectionStringType.RedisCache;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PostgreSQL")) return ConnectionStringType.PostgreSql;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ConnectionStringType value.");
        }
    }
}
