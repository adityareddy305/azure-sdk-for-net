// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceBus.Models
{
    internal static partial class ServiceBusAccessRightExtensions
    {
        public static string ToSerialString(this ServiceBusAccessRight value) => value switch
        {
            ServiceBusAccessRight.Manage => "Manage",
            ServiceBusAccessRight.Send => "Send",
            ServiceBusAccessRight.Listen => "Listen",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceBusAccessRight value.")
        };

        public static ServiceBusAccessRight ToServiceBusAccessRight(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Manage")) return ServiceBusAccessRight.Manage;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Send")) return ServiceBusAccessRight.Send;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Listen")) return ServiceBusAccessRight.Listen;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceBusAccessRight value.");
        }
    }
}
