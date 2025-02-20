// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Policy for controlling export on the disk. </summary>
    public readonly partial struct DiskPublicNetworkAccess : IEquatable<DiskPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> You can generate a SAS URI to access the underlying data of the disk publicly on the internet when NetworkAccessPolicy is set to AllowAll. You can access the data via the SAS URI only from your trusted Azure VNET when NetworkAccessPolicy is set to AllowPrivate. </summary>
        public static DiskPublicNetworkAccess Enabled { get; } = new DiskPublicNetworkAccess(EnabledValue);
        /// <summary> You cannot access the underlying data of the disk publicly on the internet even when NetworkAccessPolicy is set to AllowAll. You can access the data via the SAS URI only from your trusted Azure VNET when NetworkAccessPolicy is set to AllowPrivate. </summary>
        public static DiskPublicNetworkAccess Disabled { get; } = new DiskPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="DiskPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(DiskPublicNetworkAccess left, DiskPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(DiskPublicNetworkAccess left, DiskPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DiskPublicNetworkAccess"/>. </summary>
        public static implicit operator DiskPublicNetworkAccess(string value) => new DiskPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
