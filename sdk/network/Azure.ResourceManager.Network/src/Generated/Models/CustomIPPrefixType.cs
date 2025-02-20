// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Type of custom IP prefix. Should be Singular, Parent, or Child. </summary>
    public readonly partial struct CustomIPPrefixType : IEquatable<CustomIPPrefixType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CustomIPPrefixType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CustomIPPrefixType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingularValue = "Singular";
        private const string ParentValue = "Parent";
        private const string ChildValue = "Child";

        /// <summary> Singular. </summary>
        public static CustomIPPrefixType Singular { get; } = new CustomIPPrefixType(SingularValue);
        /// <summary> Parent. </summary>
        public static CustomIPPrefixType Parent { get; } = new CustomIPPrefixType(ParentValue);
        /// <summary> Child. </summary>
        public static CustomIPPrefixType Child { get; } = new CustomIPPrefixType(ChildValue);
        /// <summary> Determines if two <see cref="CustomIPPrefixType"/> values are the same. </summary>
        public static bool operator ==(CustomIPPrefixType left, CustomIPPrefixType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CustomIPPrefixType"/> values are not the same. </summary>
        public static bool operator !=(CustomIPPrefixType left, CustomIPPrefixType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CustomIPPrefixType"/>. </summary>
        public static implicit operator CustomIPPrefixType(string value) => new CustomIPPrefixType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CustomIPPrefixType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CustomIPPrefixType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
