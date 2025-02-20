// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The rental and lease key type. </summary>
    public readonly partial struct ContentKeyPolicyFairPlayRentalAndLeaseKeyType : IEquatable<ContentKeyPolicyFairPlayRentalAndLeaseKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyFairPlayRentalAndLeaseKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContentKeyPolicyFairPlayRentalAndLeaseKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string UndefinedValue = "Undefined";
        private const string DualExpiryValue = "DualExpiry";
        private const string PersistentUnlimitedValue = "PersistentUnlimited";
        private const string PersistentLimitedValue = "PersistentLimited";

        /// <summary> Represents a ContentKeyPolicyFairPlayRentalAndLeaseKeyType that is unavailable in current API version. </summary>
        public static ContentKeyPolicyFairPlayRentalAndLeaseKeyType Unknown { get; } = new ContentKeyPolicyFairPlayRentalAndLeaseKeyType(UnknownValue);
        /// <summary> Key duration is not specified. </summary>
        public static ContentKeyPolicyFairPlayRentalAndLeaseKeyType Undefined { get; } = new ContentKeyPolicyFairPlayRentalAndLeaseKeyType(UndefinedValue);
        /// <summary> Dual expiry for offline rental. </summary>
        public static ContentKeyPolicyFairPlayRentalAndLeaseKeyType DualExpiry { get; } = new ContentKeyPolicyFairPlayRentalAndLeaseKeyType(DualExpiryValue);
        /// <summary> Content key can be persisted with an unlimited duration. </summary>
        public static ContentKeyPolicyFairPlayRentalAndLeaseKeyType PersistentUnlimited { get; } = new ContentKeyPolicyFairPlayRentalAndLeaseKeyType(PersistentUnlimitedValue);
        /// <summary> Content key can be persisted and the valid duration is limited by the Rental Duration value. </summary>
        public static ContentKeyPolicyFairPlayRentalAndLeaseKeyType PersistentLimited { get; } = new ContentKeyPolicyFairPlayRentalAndLeaseKeyType(PersistentLimitedValue);
        /// <summary> Determines if two <see cref="ContentKeyPolicyFairPlayRentalAndLeaseKeyType"/> values are the same. </summary>
        public static bool operator ==(ContentKeyPolicyFairPlayRentalAndLeaseKeyType left, ContentKeyPolicyFairPlayRentalAndLeaseKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContentKeyPolicyFairPlayRentalAndLeaseKeyType"/> values are not the same. </summary>
        public static bool operator !=(ContentKeyPolicyFairPlayRentalAndLeaseKeyType left, ContentKeyPolicyFairPlayRentalAndLeaseKeyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContentKeyPolicyFairPlayRentalAndLeaseKeyType"/>. </summary>
        public static implicit operator ContentKeyPolicyFairPlayRentalAndLeaseKeyType(string value) => new ContentKeyPolicyFairPlayRentalAndLeaseKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContentKeyPolicyFairPlayRentalAndLeaseKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContentKeyPolicyFairPlayRentalAndLeaseKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
