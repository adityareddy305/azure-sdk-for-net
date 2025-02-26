// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ImpactReporting.Models
{
    /// <summary> Enum for connector types. </summary>
    public readonly partial struct Platform : IEquatable<Platform>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Platform"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Platform(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureMonitorValue = "AzureMonitor";

        /// <summary> Type of Azure Monitor. </summary>
        public static Platform AzureMonitor { get; } = new Platform(AzureMonitorValue);
        /// <summary> Determines if two <see cref="Platform"/> values are the same. </summary>
        public static bool operator ==(Platform left, Platform right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Platform"/> values are not the same. </summary>
        public static bool operator !=(Platform left, Platform right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="Platform"/>. </summary>
        public static implicit operator Platform(string value) => new Platform(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Platform other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Platform other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
