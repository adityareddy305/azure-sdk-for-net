// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The ManagedLedgerDigestUploadsName. </summary>
    public readonly partial struct ManagedLedgerDigestUploadsName : IEquatable<ManagedLedgerDigestUploadsName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedLedgerDigestUploadsName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedLedgerDigestUploadsName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "current";

        /// <summary> current. </summary>
        public static ManagedLedgerDigestUploadsName Current { get; } = new ManagedLedgerDigestUploadsName(CurrentValue);
        /// <summary> Determines if two <see cref="ManagedLedgerDigestUploadsName"/> values are the same. </summary>
        public static bool operator ==(ManagedLedgerDigestUploadsName left, ManagedLedgerDigestUploadsName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedLedgerDigestUploadsName"/> values are not the same. </summary>
        public static bool operator !=(ManagedLedgerDigestUploadsName left, ManagedLedgerDigestUploadsName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedLedgerDigestUploadsName"/>. </summary>
        public static implicit operator ManagedLedgerDigestUploadsName(string value) => new ManagedLedgerDigestUploadsName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedLedgerDigestUploadsName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedLedgerDigestUploadsName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
