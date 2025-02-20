// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The mode by which the cluster will target the next grouping of servers to continue the update. </summary>
    public readonly partial struct ClusterContinueUpdateVersionMachineGroupTargetingMode : IEquatable<ClusterContinueUpdateVersionMachineGroupTargetingMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterContinueUpdateVersionMachineGroupTargetingMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterContinueUpdateVersionMachineGroupTargetingMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlphaByRackValue = "AlphaByRack";

        /// <summary> AlphaByRack. </summary>
        public static ClusterContinueUpdateVersionMachineGroupTargetingMode AlphaByRack { get; } = new ClusterContinueUpdateVersionMachineGroupTargetingMode(AlphaByRackValue);
        /// <summary> Determines if two <see cref="ClusterContinueUpdateVersionMachineGroupTargetingMode"/> values are the same. </summary>
        public static bool operator ==(ClusterContinueUpdateVersionMachineGroupTargetingMode left, ClusterContinueUpdateVersionMachineGroupTargetingMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterContinueUpdateVersionMachineGroupTargetingMode"/> values are not the same. </summary>
        public static bool operator !=(ClusterContinueUpdateVersionMachineGroupTargetingMode left, ClusterContinueUpdateVersionMachineGroupTargetingMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClusterContinueUpdateVersionMachineGroupTargetingMode"/>. </summary>
        public static implicit operator ClusterContinueUpdateVersionMachineGroupTargetingMode(string value) => new ClusterContinueUpdateVersionMachineGroupTargetingMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterContinueUpdateVersionMachineGroupTargetingMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterContinueUpdateVersionMachineGroupTargetingMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
