// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The AuthenticationName. </summary>
    public readonly partial struct AuthenticationName : IEquatable<AuthenticationName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AuthenticationName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AuthenticationName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";

        /// <summary> Default. </summary>
        public static AuthenticationName Default { get; } = new AuthenticationName(DefaultValue);
        /// <summary> Determines if two <see cref="AuthenticationName"/> values are the same. </summary>
        public static bool operator ==(AuthenticationName left, AuthenticationName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AuthenticationName"/> values are not the same. </summary>
        public static bool operator !=(AuthenticationName left, AuthenticationName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AuthenticationName"/>. </summary>
        public static implicit operator AuthenticationName(string value) => new AuthenticationName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AuthenticationName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AuthenticationName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
