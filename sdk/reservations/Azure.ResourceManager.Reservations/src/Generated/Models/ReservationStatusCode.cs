// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The ReservationStatusCode. </summary>
    public readonly partial struct ReservationStatusCode : IEquatable<ReservationStatusCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReservationStatusCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservationStatusCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string PendingValue = "Pending";
        private const string ProcessingValue = "Processing";
        private const string ActiveValue = "Active";
        private const string PurchaseErrorValue = "PurchaseError";
        private const string PaymentInstrumentErrorValue = "PaymentInstrumentError";
        private const string SplitValue = "Split";
        private const string MergedValue = "Merged";
        private const string ExpiredValue = "Expired";
        private const string SucceededValue = "Succeeded";

        /// <summary> None. </summary>
        public static ReservationStatusCode None { get; } = new ReservationStatusCode(NoneValue);
        /// <summary> Pending. </summary>
        public static ReservationStatusCode Pending { get; } = new ReservationStatusCode(PendingValue);
        /// <summary> Processing. </summary>
        public static ReservationStatusCode Processing { get; } = new ReservationStatusCode(ProcessingValue);
        /// <summary> Active. </summary>
        public static ReservationStatusCode Active { get; } = new ReservationStatusCode(ActiveValue);
        /// <summary> PurchaseError. </summary>
        public static ReservationStatusCode PurchaseError { get; } = new ReservationStatusCode(PurchaseErrorValue);
        /// <summary> PaymentInstrumentError. </summary>
        public static ReservationStatusCode PaymentInstrumentError { get; } = new ReservationStatusCode(PaymentInstrumentErrorValue);
        /// <summary> Split. </summary>
        public static ReservationStatusCode Split { get; } = new ReservationStatusCode(SplitValue);
        /// <summary> Merged. </summary>
        public static ReservationStatusCode Merged { get; } = new ReservationStatusCode(MergedValue);
        /// <summary> Expired. </summary>
        public static ReservationStatusCode Expired { get; } = new ReservationStatusCode(ExpiredValue);
        /// <summary> Succeeded. </summary>
        public static ReservationStatusCode Succeeded { get; } = new ReservationStatusCode(SucceededValue);
        /// <summary> Determines if two <see cref="ReservationStatusCode"/> values are the same. </summary>
        public static bool operator ==(ReservationStatusCode left, ReservationStatusCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservationStatusCode"/> values are not the same. </summary>
        public static bool operator !=(ReservationStatusCode left, ReservationStatusCode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ReservationStatusCode"/>. </summary>
        public static implicit operator ReservationStatusCode(string value) => new ReservationStatusCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservationStatusCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservationStatusCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
