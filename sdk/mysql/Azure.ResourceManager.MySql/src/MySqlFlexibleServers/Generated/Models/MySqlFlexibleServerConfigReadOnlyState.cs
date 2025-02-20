// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> If is the configuration read only. </summary>
    public readonly partial struct MySqlFlexibleServerConfigReadOnlyState : IEquatable<MySqlFlexibleServerConfigReadOnlyState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerConfigReadOnlyState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MySqlFlexibleServerConfigReadOnlyState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static MySqlFlexibleServerConfigReadOnlyState True { get; } = new MySqlFlexibleServerConfigReadOnlyState(TrueValue);
        /// <summary> False. </summary>
        public static MySqlFlexibleServerConfigReadOnlyState False { get; } = new MySqlFlexibleServerConfigReadOnlyState(FalseValue);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerConfigReadOnlyState"/> values are the same. </summary>
        public static bool operator ==(MySqlFlexibleServerConfigReadOnlyState left, MySqlFlexibleServerConfigReadOnlyState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerConfigReadOnlyState"/> values are not the same. </summary>
        public static bool operator !=(MySqlFlexibleServerConfigReadOnlyState left, MySqlFlexibleServerConfigReadOnlyState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MySqlFlexibleServerConfigReadOnlyState"/>. </summary>
        public static implicit operator MySqlFlexibleServerConfigReadOnlyState(string value) => new MySqlFlexibleServerConfigReadOnlyState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MySqlFlexibleServerConfigReadOnlyState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MySqlFlexibleServerConfigReadOnlyState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
