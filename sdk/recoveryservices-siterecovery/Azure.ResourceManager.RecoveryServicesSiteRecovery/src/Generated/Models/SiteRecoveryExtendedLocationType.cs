// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The extended location type. </summary>
    public readonly partial struct SiteRecoveryExtendedLocationType : IEquatable<SiteRecoveryExtendedLocationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryExtendedLocationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SiteRecoveryExtendedLocationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EdgeZoneValue = "EdgeZone";

        /// <summary> EdgeZone. </summary>
        public static SiteRecoveryExtendedLocationType EdgeZone { get; } = new SiteRecoveryExtendedLocationType(EdgeZoneValue);
        /// <summary> Determines if two <see cref="SiteRecoveryExtendedLocationType"/> values are the same. </summary>
        public static bool operator ==(SiteRecoveryExtendedLocationType left, SiteRecoveryExtendedLocationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SiteRecoveryExtendedLocationType"/> values are not the same. </summary>
        public static bool operator !=(SiteRecoveryExtendedLocationType left, SiteRecoveryExtendedLocationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SiteRecoveryExtendedLocationType"/>. </summary>
        public static implicit operator SiteRecoveryExtendedLocationType(string value) => new SiteRecoveryExtendedLocationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SiteRecoveryExtendedLocationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SiteRecoveryExtendedLocationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
