// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Various states of the SSO resource. </summary>
    public readonly partial struct SingleSignOnState : IEquatable<SingleSignOnState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SingleSignOnState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SingleSignOnState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitialValue = "Initial";
        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";
        private const string ExistingValue = "Existing";

        /// <summary> Initial. </summary>
        public static SingleSignOnState Initial { get; } = new SingleSignOnState(InitialValue);
        /// <summary> Enable. </summary>
        public static SingleSignOnState Enable { get; } = new SingleSignOnState(EnableValue);
        /// <summary> Disable. </summary>
        public static SingleSignOnState Disable { get; } = new SingleSignOnState(DisableValue);
        /// <summary> Existing. </summary>
        public static SingleSignOnState Existing { get; } = new SingleSignOnState(ExistingValue);
        /// <summary> Determines if two <see cref="SingleSignOnState"/> values are the same. </summary>
        public static bool operator ==(SingleSignOnState left, SingleSignOnState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SingleSignOnState"/> values are not the same. </summary>
        public static bool operator !=(SingleSignOnState left, SingleSignOnState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SingleSignOnState"/>. </summary>
        public static implicit operator SingleSignOnState(string value) => new SingleSignOnState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SingleSignOnState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SingleSignOnState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
