// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    /// <summary> The status of the machine resource. </summary>
    public readonly partial struct DevOpsResourceStatus : IEquatable<DevOpsResourceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevOpsResourceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevOpsResourceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadyValue = "Ready";
        private const string NotReadyValue = "NotReady";
        private const string AllocatedValue = "Allocated";
        private const string PendingReturnValue = "PendingReturn";
        private const string ReturnedValue = "Returned";
        private const string LeasedValue = "Leased";
        private const string ProvisioningValue = "Provisioning";
        private const string UpdatingValue = "Updating";
        private const string StartingValue = "Starting";
        private const string PendingReimageValue = "PendingReimage";
        private const string ReimagingValue = "Reimaging";

        /// <summary> Represents a machine resource that is ready. </summary>
        public static DevOpsResourceStatus Ready { get; } = new DevOpsResourceStatus(ReadyValue);
        /// <summary> Represents a machine resource that is not ready. </summary>
        public static DevOpsResourceStatus NotReady { get; } = new DevOpsResourceStatus(NotReadyValue);
        /// <summary> Represents a machine resource that is allocated. </summary>
        public static DevOpsResourceStatus Allocated { get; } = new DevOpsResourceStatus(AllocatedValue);
        /// <summary> Represents a machine resource that is pending return. </summary>
        public static DevOpsResourceStatus PendingReturn { get; } = new DevOpsResourceStatus(PendingReturnValue);
        /// <summary> Represents a machine resource that is returned. </summary>
        public static DevOpsResourceStatus Returned { get; } = new DevOpsResourceStatus(ReturnedValue);
        /// <summary> Represents a machine resource that is leased. </summary>
        public static DevOpsResourceStatus Leased { get; } = new DevOpsResourceStatus(LeasedValue);
        /// <summary> Represents a machine resource that is provisioning. </summary>
        public static DevOpsResourceStatus Provisioning { get; } = new DevOpsResourceStatus(ProvisioningValue);
        /// <summary> Represents a machine resource that is updating. </summary>
        public static DevOpsResourceStatus Updating { get; } = new DevOpsResourceStatus(UpdatingValue);
        /// <summary> Represents a machine resource that is starting. </summary>
        public static DevOpsResourceStatus Starting { get; } = new DevOpsResourceStatus(StartingValue);
        /// <summary> Represents a machine resource that is pending reimage. </summary>
        public static DevOpsResourceStatus PendingReimage { get; } = new DevOpsResourceStatus(PendingReimageValue);
        /// <summary> Represents a machine resource that is reimaging. </summary>
        public static DevOpsResourceStatus Reimaging { get; } = new DevOpsResourceStatus(ReimagingValue);
        /// <summary> Determines if two <see cref="DevOpsResourceStatus"/> values are the same. </summary>
        public static bool operator ==(DevOpsResourceStatus left, DevOpsResourceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevOpsResourceStatus"/> values are not the same. </summary>
        public static bool operator !=(DevOpsResourceStatus left, DevOpsResourceStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DevOpsResourceStatus"/>. </summary>
        public static implicit operator DevOpsResourceStatus(string value) => new DevOpsResourceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevOpsResourceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevOpsResourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
