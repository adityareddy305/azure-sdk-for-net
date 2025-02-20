// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> Describes directionality e.g. oneWay or twoWay. </summary>
    public readonly partial struct MessageDirectionality : IEquatable<MessageDirectionality>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageDirectionality"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageDirectionality(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OneWayValue = "oneWay";
        private const string TwoWayValue = "twoWay";

        /// <summary> oneWay. </summary>
        public static MessageDirectionality OneWay { get; } = new MessageDirectionality(OneWayValue);
        /// <summary> twoWay. </summary>
        public static MessageDirectionality TwoWay { get; } = new MessageDirectionality(TwoWayValue);
        /// <summary> Determines if two <see cref="MessageDirectionality"/> values are the same. </summary>
        public static bool operator ==(MessageDirectionality left, MessageDirectionality right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageDirectionality"/> values are not the same. </summary>
        public static bool operator !=(MessageDirectionality left, MessageDirectionality right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MessageDirectionality"/>. </summary>
        public static implicit operator MessageDirectionality(string value) => new MessageDirectionality(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageDirectionality other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageDirectionality other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
