// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> The MessageDeltaChunk_object. </summary>
    public readonly partial struct MessageDeltaChunkObject : IEquatable<MessageDeltaChunkObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageDeltaChunkObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageDeltaChunkObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadMessageDeltaValue = "thread.message.delta";

        /// <summary> thread.message.delta. </summary>
        public static MessageDeltaChunkObject ThreadMessageDelta { get; } = new MessageDeltaChunkObject(ThreadMessageDeltaValue);
        /// <summary> Determines if two <see cref="MessageDeltaChunkObject"/> values are the same. </summary>
        public static bool operator ==(MessageDeltaChunkObject left, MessageDeltaChunkObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageDeltaChunkObject"/> values are not the same. </summary>
        public static bool operator !=(MessageDeltaChunkObject left, MessageDeltaChunkObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MessageDeltaChunkObject"/>. </summary>
        public static implicit operator MessageDeltaChunkObject(string value) => new MessageDeltaChunkObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageDeltaChunkObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageDeltaChunkObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
