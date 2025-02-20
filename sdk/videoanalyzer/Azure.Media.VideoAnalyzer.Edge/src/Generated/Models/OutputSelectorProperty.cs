// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The property of the data stream to be used as the selection criteria. </summary>
    public readonly partial struct OutputSelectorProperty : IEquatable<OutputSelectorProperty>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OutputSelectorProperty"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OutputSelectorProperty(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MediaTypeValue = "mediaType";

        /// <summary> The stream's MIME type or subtype: audio, video or application. </summary>
        public static OutputSelectorProperty MediaType { get; } = new OutputSelectorProperty(MediaTypeValue);
        /// <summary> Determines if two <see cref="OutputSelectorProperty"/> values are the same. </summary>
        public static bool operator ==(OutputSelectorProperty left, OutputSelectorProperty right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OutputSelectorProperty"/> values are not the same. </summary>
        public static bool operator !=(OutputSelectorProperty left, OutputSelectorProperty right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OutputSelectorProperty"/>. </summary>
        public static implicit operator OutputSelectorProperty(string value) => new OutputSelectorProperty(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OutputSelectorProperty other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OutputSelectorProperty other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
