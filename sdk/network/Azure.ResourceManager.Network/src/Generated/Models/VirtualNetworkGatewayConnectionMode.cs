// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Gateway connection type. </summary>
    public readonly partial struct VirtualNetworkGatewayConnectionMode : IEquatable<VirtualNetworkGatewayConnectionMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayConnectionMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualNetworkGatewayConnectionMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string ResponderOnlyValue = "ResponderOnly";
        private const string InitiatorOnlyValue = "InitiatorOnly";

        /// <summary> Default. </summary>
        public static VirtualNetworkGatewayConnectionMode Default { get; } = new VirtualNetworkGatewayConnectionMode(DefaultValue);
        /// <summary> ResponderOnly. </summary>
        public static VirtualNetworkGatewayConnectionMode ResponderOnly { get; } = new VirtualNetworkGatewayConnectionMode(ResponderOnlyValue);
        /// <summary> InitiatorOnly. </summary>
        public static VirtualNetworkGatewayConnectionMode InitiatorOnly { get; } = new VirtualNetworkGatewayConnectionMode(InitiatorOnlyValue);
        /// <summary> Determines if two <see cref="VirtualNetworkGatewayConnectionMode"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkGatewayConnectionMode left, VirtualNetworkGatewayConnectionMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkGatewayConnectionMode"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkGatewayConnectionMode left, VirtualNetworkGatewayConnectionMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VirtualNetworkGatewayConnectionMode"/>. </summary>
        public static implicit operator VirtualNetworkGatewayConnectionMode(string value) => new VirtualNetworkGatewayConnectionMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkGatewayConnectionMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkGatewayConnectionMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
