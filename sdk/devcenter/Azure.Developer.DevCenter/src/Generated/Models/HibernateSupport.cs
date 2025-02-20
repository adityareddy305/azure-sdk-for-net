// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Indicates whether hibernate is supported and enabled, disabled, or unsupported by the operating system. Unknown hibernate support is represented as null. </summary>
    public readonly partial struct HibernateSupport : IEquatable<HibernateSupport>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HibernateSupport"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HibernateSupport(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";
        private const string OsUnsupportedValue = "OsUnsupported";

        /// <summary> Hibernate is enabled. </summary>
        public static HibernateSupport Enabled { get; } = new HibernateSupport(EnabledValue);
        /// <summary> Hibernate is not enabled. </summary>
        public static HibernateSupport Disabled { get; } = new HibernateSupport(DisabledValue);
        /// <summary> Hibernate is not supported by the operating system. </summary>
        public static HibernateSupport OsUnsupported { get; } = new HibernateSupport(OsUnsupportedValue);
        /// <summary> Determines if two <see cref="HibernateSupport"/> values are the same. </summary>
        public static bool operator ==(HibernateSupport left, HibernateSupport right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HibernateSupport"/> values are not the same. </summary>
        public static bool operator !=(HibernateSupport left, HibernateSupport right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HibernateSupport"/>. </summary>
        public static implicit operator HibernateSupport(string value) => new HibernateSupport(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HibernateSupport other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HibernateSupport other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
