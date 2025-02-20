// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> The PostgreSqlMigrationListFilter. </summary>
    public readonly partial struct PostgreSqlMigrationListFilter : IEquatable<PostgreSqlMigrationListFilter>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationListFilter"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlMigrationListFilter(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string AllValue = "All";

        /// <summary> Active. </summary>
        public static PostgreSqlMigrationListFilter Active { get; } = new PostgreSqlMigrationListFilter(ActiveValue);
        /// <summary> All. </summary>
        public static PostgreSqlMigrationListFilter All { get; } = new PostgreSqlMigrationListFilter(AllValue);
        /// <summary> Determines if two <see cref="PostgreSqlMigrationListFilter"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlMigrationListFilter left, PostgreSqlMigrationListFilter right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlMigrationListFilter"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlMigrationListFilter left, PostgreSqlMigrationListFilter right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlMigrationListFilter"/>. </summary>
        public static implicit operator PostgreSqlMigrationListFilter(string value) => new PostgreSqlMigrationListFilter(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlMigrationListFilter other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlMigrationListFilter other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
