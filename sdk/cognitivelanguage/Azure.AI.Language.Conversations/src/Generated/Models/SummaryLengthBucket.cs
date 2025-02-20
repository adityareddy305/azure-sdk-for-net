// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Enum that defines the length of the output summaries. </summary>
    public readonly partial struct SummaryLengthBucket : IEquatable<SummaryLengthBucket>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SummaryLengthBucket"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SummaryLengthBucket(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ShortValue = "short";
        private const string MediumValue = "medium";
        private const string LongValue = "long";

        /// <summary> Instructs model to generate shorter length summaries. </summary>
        public static SummaryLengthBucket Short { get; } = new SummaryLengthBucket(ShortValue);
        /// <summary> Instructs model to generate medium length summaries. </summary>
        public static SummaryLengthBucket Medium { get; } = new SummaryLengthBucket(MediumValue);
        /// <summary> Instructs model to generate longer length summaries. </summary>
        public static SummaryLengthBucket Long { get; } = new SummaryLengthBucket(LongValue);
        /// <summary> Determines if two <see cref="SummaryLengthBucket"/> values are the same. </summary>
        public static bool operator ==(SummaryLengthBucket left, SummaryLengthBucket right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SummaryLengthBucket"/> values are not the same. </summary>
        public static bool operator !=(SummaryLengthBucket left, SummaryLengthBucket right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SummaryLengthBucket"/>. </summary>
        public static implicit operator SummaryLengthBucket(string value) => new SummaryLengthBucket(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SummaryLengthBucket other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SummaryLengthBucket other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
