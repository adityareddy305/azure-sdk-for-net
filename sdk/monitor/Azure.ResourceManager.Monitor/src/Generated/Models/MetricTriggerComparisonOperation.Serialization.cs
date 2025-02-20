// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    internal static partial class MetricTriggerComparisonOperationExtensions
    {
        public static string ToSerialString(this MetricTriggerComparisonOperation value) => value switch
        {
            MetricTriggerComparisonOperation.EqualsValue => "Equals",
            MetricTriggerComparisonOperation.NotEquals => "NotEquals",
            MetricTriggerComparisonOperation.GreaterThan => "GreaterThan",
            MetricTriggerComparisonOperation.GreaterThanOrEqual => "GreaterThanOrEqual",
            MetricTriggerComparisonOperation.LessThan => "LessThan",
            MetricTriggerComparisonOperation.LessThanOrEqual => "LessThanOrEqual",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MetricTriggerComparisonOperation value.")
        };

        public static MetricTriggerComparisonOperation ToMetricTriggerComparisonOperation(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Equals")) return MetricTriggerComparisonOperation.EqualsValue;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotEquals")) return MetricTriggerComparisonOperation.NotEquals;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "GreaterThan")) return MetricTriggerComparisonOperation.GreaterThan;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "GreaterThanOrEqual")) return MetricTriggerComparisonOperation.GreaterThanOrEqual;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "LessThan")) return MetricTriggerComparisonOperation.LessThan;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "LessThanOrEqual")) return MetricTriggerComparisonOperation.LessThanOrEqual;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MetricTriggerComparisonOperation value.");
        }
    }
}
