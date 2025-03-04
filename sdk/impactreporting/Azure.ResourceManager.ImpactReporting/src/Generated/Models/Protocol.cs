// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ImpactReporting.Models
{
    /// <summary> List of protocols. </summary>
    public readonly partial struct Protocol : IEquatable<Protocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Protocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Protocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TCPValue = "TCP";
        private const string UDPValue = "UDP";
        private const string HTTPValue = "HTTP";
        private const string HTTPSValue = "HTTPS";
        private const string RDPValue = "RDP";
        private const string FTPValue = "FTP";
        private const string SSHValue = "SSH";
        private const string OtherValue = "Other";

        /// <summary> When communication protocol is TCP. </summary>
        public static Protocol TCP { get; } = new Protocol(TCPValue);
        /// <summary> When communication protocol is UDP. </summary>
        public static Protocol UDP { get; } = new Protocol(UDPValue);
        /// <summary> When communication protocol is HTTP. </summary>
        public static Protocol HTTP { get; } = new Protocol(HTTPValue);
        /// <summary> When communication protocol is HTTPS. </summary>
        public static Protocol HTTPS { get; } = new Protocol(HTTPSValue);
        /// <summary> When communication protocol is RDP. </summary>
        public static Protocol RDP { get; } = new Protocol(RDPValue);
        /// <summary> When communication protocol is FTP. </summary>
        public static Protocol FTP { get; } = new Protocol(FTPValue);
        /// <summary> When communication protocol is SSH. </summary>
        public static Protocol SSH { get; } = new Protocol(SSHValue);
        /// <summary> When communication protocol is Other. </summary>
        public static Protocol Other { get; } = new Protocol(OtherValue);
        /// <summary> Determines if two <see cref="Protocol"/> values are the same. </summary>
        public static bool operator ==(Protocol left, Protocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Protocol"/> values are not the same. </summary>
        public static bool operator !=(Protocol left, Protocol right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="Protocol"/>. </summary>
        public static implicit operator Protocol(string value) => new Protocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Protocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Protocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
