// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Type of the Environment Variable. Possible values are: local - For local variable. </summary>
    public readonly partial struct EnvironmentVariableType : IEquatable<EnvironmentVariableType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnvironmentVariableType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnvironmentVariableType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LocalValue = "local";

        /// <summary> local. </summary>
        public static EnvironmentVariableType Local { get; } = new EnvironmentVariableType(LocalValue);
        /// <summary> Determines if two <see cref="EnvironmentVariableType"/> values are the same. </summary>
        public static bool operator ==(EnvironmentVariableType left, EnvironmentVariableType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnvironmentVariableType"/> values are not the same. </summary>
        public static bool operator !=(EnvironmentVariableType left, EnvironmentVariableType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EnvironmentVariableType"/>. </summary>
        public static implicit operator EnvironmentVariableType(string value) => new EnvironmentVariableType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnvironmentVariableType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnvironmentVariableType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
