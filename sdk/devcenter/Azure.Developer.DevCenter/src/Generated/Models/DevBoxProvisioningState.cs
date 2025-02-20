// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Indicates the provisioning state of the Dev Box. </summary>
    public readonly partial struct DevBoxProvisioningState : IEquatable<DevBoxProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevBoxProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevBoxProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string StartingValue = "Starting";
        private const string StoppingValue = "Stopping";
        private const string ProvisioningValue = "Provisioning";
        private const string ProvisionedWithWarningValue = "ProvisionedWithWarning";
        private const string InGracePeriodValue = "InGracePeriod";
        private const string NotProvisionedValue = "NotProvisioned";

        /// <summary> Dev Box was successfully provisioned. </summary>
        public static DevBoxProvisioningState Succeeded { get; } = new DevBoxProvisioningState(SucceededValue);
        /// <summary> Dev Box failed to provision. </summary>
        public static DevBoxProvisioningState Failed { get; } = new DevBoxProvisioningState(FailedValue);
        /// <summary> Dev Box provision was canceled. </summary>
        public static DevBoxProvisioningState Canceled { get; } = new DevBoxProvisioningState(CanceledValue);
        /// <summary> Dev Box is being created. </summary>
        public static DevBoxProvisioningState Creating { get; } = new DevBoxProvisioningState(CreatingValue);
        /// <summary> Dev Box is being deleted. </summary>
        public static DevBoxProvisioningState Deleting { get; } = new DevBoxProvisioningState(DeletingValue);
        /// <summary> Dev Box is updating. </summary>
        public static DevBoxProvisioningState Updating { get; } = new DevBoxProvisioningState(UpdatingValue);
        /// <summary> Dev Box is starting. </summary>
        public static DevBoxProvisioningState Starting { get; } = new DevBoxProvisioningState(StartingValue);
        /// <summary> Dev Box is stopping. </summary>
        public static DevBoxProvisioningState Stopping { get; } = new DevBoxProvisioningState(StoppingValue);
        /// <summary> Dev Box is provisioning. </summary>
        public static DevBoxProvisioningState Provisioning { get; } = new DevBoxProvisioningState(ProvisioningValue);
        /// <summary> Dev Box was provisioned with warning. </summary>
        public static DevBoxProvisioningState ProvisionedWithWarning { get; } = new DevBoxProvisioningState(ProvisionedWithWarningValue);
        /// <summary> Dev Box is in grace period. </summary>
        public static DevBoxProvisioningState InGracePeriod { get; } = new DevBoxProvisioningState(InGracePeriodValue);
        /// <summary> Dev Box is not provisioned. </summary>
        public static DevBoxProvisioningState NotProvisioned { get; } = new DevBoxProvisioningState(NotProvisionedValue);
        /// <summary> Determines if two <see cref="DevBoxProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DevBoxProvisioningState left, DevBoxProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevBoxProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DevBoxProvisioningState left, DevBoxProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DevBoxProvisioningState"/>. </summary>
        public static implicit operator DevBoxProvisioningState(string value) => new DevBoxProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevBoxProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevBoxProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
