// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Cluster principal role. </summary>
    public readonly partial struct SynapseClusterPrincipalRole : IEquatable<SynapseClusterPrincipalRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseClusterPrincipalRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseClusterPrincipalRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllDatabasesAdminValue = "AllDatabasesAdmin";
        private const string AllDatabasesViewerValue = "AllDatabasesViewer";

        /// <summary> AllDatabasesAdmin. </summary>
        public static SynapseClusterPrincipalRole AllDatabasesAdmin { get; } = new SynapseClusterPrincipalRole(AllDatabasesAdminValue);
        /// <summary> AllDatabasesViewer. </summary>
        public static SynapseClusterPrincipalRole AllDatabasesViewer { get; } = new SynapseClusterPrincipalRole(AllDatabasesViewerValue);
        /// <summary> Determines if two <see cref="SynapseClusterPrincipalRole"/> values are the same. </summary>
        public static bool operator ==(SynapseClusterPrincipalRole left, SynapseClusterPrincipalRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseClusterPrincipalRole"/> values are not the same. </summary>
        public static bool operator !=(SynapseClusterPrincipalRole left, SynapseClusterPrincipalRole right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SynapseClusterPrincipalRole"/>. </summary>
        public static implicit operator SynapseClusterPrincipalRole(string value) => new SynapseClusterPrincipalRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseClusterPrincipalRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseClusterPrincipalRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
