// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The service principal credential type to use in Server-To-Server authentication. 'ServicePrincipalKey' for key/secret, 'ServicePrincipalCert' for certificate. Type: string (or Expression with resultType string). </summary>
    internal readonly partial struct DynamicsServicePrincipalCredentialType : IEquatable<DynamicsServicePrincipalCredentialType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynamicsServicePrincipalCredentialType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynamicsServicePrincipalCredentialType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServicePrincipalKeyValue = "ServicePrincipalKey";
        private const string ServicePrincipalCertValue = "ServicePrincipalCert";

        /// <summary> ServicePrincipalKey. </summary>
        public static DynamicsServicePrincipalCredentialType ServicePrincipalKey { get; } = new DynamicsServicePrincipalCredentialType(ServicePrincipalKeyValue);
        /// <summary> ServicePrincipalCert. </summary>
        public static DynamicsServicePrincipalCredentialType ServicePrincipalCert { get; } = new DynamicsServicePrincipalCredentialType(ServicePrincipalCertValue);
        /// <summary> Determines if two <see cref="DynamicsServicePrincipalCredentialType"/> values are the same. </summary>
        public static bool operator ==(DynamicsServicePrincipalCredentialType left, DynamicsServicePrincipalCredentialType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynamicsServicePrincipalCredentialType"/> values are not the same. </summary>
        public static bool operator !=(DynamicsServicePrincipalCredentialType left, DynamicsServicePrincipalCredentialType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DynamicsServicePrincipalCredentialType"/>. </summary>
        public static implicit operator DynamicsServicePrincipalCredentialType(string value) => new DynamicsServicePrincipalCredentialType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynamicsServicePrincipalCredentialType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynamicsServicePrincipalCredentialType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
