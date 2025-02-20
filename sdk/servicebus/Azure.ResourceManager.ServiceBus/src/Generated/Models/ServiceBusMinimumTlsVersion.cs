// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> The minimum TLS version for the cluster to support, e.g. '1.2'. </summary>
    public readonly partial struct ServiceBusMinimumTlsVersion : IEquatable<ServiceBusMinimumTlsVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceBusMinimumTlsVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceBusMinimumTlsVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Tls1_0Value = "1.0";
        private const string Tls1_1Value = "1.1";
        private const string Tls1_2Value = "1.2";
        /// <summary> Determines if two <see cref="ServiceBusMinimumTlsVersion"/> values are the same. </summary>
        public static bool operator ==(ServiceBusMinimumTlsVersion left, ServiceBusMinimumTlsVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceBusMinimumTlsVersion"/> values are not the same. </summary>
        public static bool operator !=(ServiceBusMinimumTlsVersion left, ServiceBusMinimumTlsVersion right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ServiceBusMinimumTlsVersion"/>. </summary>
        public static implicit operator ServiceBusMinimumTlsVersion(string value) => new ServiceBusMinimumTlsVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceBusMinimumTlsVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceBusMinimumTlsVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
