// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the Event Grid Domain Resource. </summary>
    public readonly partial struct EventGridDomainProvisioningState : IEquatable<EventGridDomainProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridDomainProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridDomainProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static EventGridDomainProvisioningState Creating { get; } = new EventGridDomainProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static EventGridDomainProvisioningState Updating { get; } = new EventGridDomainProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static EventGridDomainProvisioningState Deleting { get; } = new EventGridDomainProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static EventGridDomainProvisioningState Succeeded { get; } = new EventGridDomainProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static EventGridDomainProvisioningState Canceled { get; } = new EventGridDomainProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static EventGridDomainProvisioningState Failed { get; } = new EventGridDomainProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="EventGridDomainProvisioningState"/> values are the same. </summary>
        public static bool operator ==(EventGridDomainProvisioningState left, EventGridDomainProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridDomainProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(EventGridDomainProvisioningState left, EventGridDomainProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventGridDomainProvisioningState"/>. </summary>
        public static implicit operator EventGridDomainProvisioningState(string value) => new EventGridDomainProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridDomainProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridDomainProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
