// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the MoveType. </summary>
    public readonly partial struct MoveType : IEquatable<MoveType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MoveType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MoveType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegionToRegionValue = "RegionToRegion";
        private const string RegionToZoneValue = "RegionToZone";

        /// <summary> RegionToRegion. </summary>
        public static MoveType RegionToRegion { get; } = new MoveType(RegionToRegionValue);
        /// <summary> RegionToZone. </summary>
        public static MoveType RegionToZone { get; } = new MoveType(RegionToZoneValue);
        /// <summary> Determines if two <see cref="MoveType"/> values are the same. </summary>
        public static bool operator ==(MoveType left, MoveType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MoveType"/> values are not the same. </summary>
        public static bool operator !=(MoveType left, MoveType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MoveType"/>. </summary>
        public static implicit operator MoveType(string value) => new MoveType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MoveType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MoveType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
