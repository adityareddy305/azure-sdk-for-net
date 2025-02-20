// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Differentiates between the type of script commands included - Database or Cluster. The default is Database. </summary>
    public readonly partial struct KustoScriptLevel : IEquatable<KustoScriptLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoScriptLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoScriptLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DatabaseValue = "Database";
        private const string ClusterValue = "Cluster";

        /// <summary> Database. </summary>
        public static KustoScriptLevel Database { get; } = new KustoScriptLevel(DatabaseValue);
        /// <summary> Cluster. </summary>
        public static KustoScriptLevel Cluster { get; } = new KustoScriptLevel(ClusterValue);
        /// <summary> Determines if two <see cref="KustoScriptLevel"/> values are the same. </summary>
        public static bool operator ==(KustoScriptLevel left, KustoScriptLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoScriptLevel"/> values are not the same. </summary>
        public static bool operator !=(KustoScriptLevel left, KustoScriptLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KustoScriptLevel"/>. </summary>
        public static implicit operator KustoScriptLevel(string value) => new KustoScriptLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoScriptLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoScriptLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
