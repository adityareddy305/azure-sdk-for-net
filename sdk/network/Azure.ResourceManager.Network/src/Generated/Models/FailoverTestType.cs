// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The type of failover test. </summary>
    public readonly partial struct FailoverTestType : IEquatable<FailoverTestType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FailoverTestType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FailoverTestType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingleSiteFailoverValue = "SingleSiteFailover";
        private const string MultiSiteFailoverValue = "MultiSiteFailover";
        private const string AllValue = "All";

        /// <summary> SingleSiteFailover. </summary>
        public static FailoverTestType SingleSiteFailover { get; } = new FailoverTestType(SingleSiteFailoverValue);
        /// <summary> MultiSiteFailover. </summary>
        public static FailoverTestType MultiSiteFailover { get; } = new FailoverTestType(MultiSiteFailoverValue);
        /// <summary> All. </summary>
        public static FailoverTestType All { get; } = new FailoverTestType(AllValue);
        /// <summary> Determines if two <see cref="FailoverTestType"/> values are the same. </summary>
        public static bool operator ==(FailoverTestType left, FailoverTestType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FailoverTestType"/> values are not the same. </summary>
        public static bool operator !=(FailoverTestType left, FailoverTestType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FailoverTestType"/>. </summary>
        public static implicit operator FailoverTestType(string value) => new FailoverTestType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FailoverTestType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FailoverTestType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
