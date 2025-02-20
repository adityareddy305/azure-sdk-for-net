// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The string representation of the web application firewall rule sensitivity. </summary>
    public readonly partial struct ApplicationGatewayWafRuleSensitivityType : IEquatable<ApplicationGatewayWafRuleSensitivityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayWafRuleSensitivityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewayWafRuleSensitivityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string LowValue = "Low";
        private const string MediumValue = "Medium";
        private const string HighValue = "High";

        /// <summary> None. </summary>
        public static ApplicationGatewayWafRuleSensitivityType None { get; } = new ApplicationGatewayWafRuleSensitivityType(NoneValue);
        /// <summary> Low. </summary>
        public static ApplicationGatewayWafRuleSensitivityType Low { get; } = new ApplicationGatewayWafRuleSensitivityType(LowValue);
        /// <summary> Medium. </summary>
        public static ApplicationGatewayWafRuleSensitivityType Medium { get; } = new ApplicationGatewayWafRuleSensitivityType(MediumValue);
        /// <summary> High. </summary>
        public static ApplicationGatewayWafRuleSensitivityType High { get; } = new ApplicationGatewayWafRuleSensitivityType(HighValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayWafRuleSensitivityType"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayWafRuleSensitivityType left, ApplicationGatewayWafRuleSensitivityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayWafRuleSensitivityType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayWafRuleSensitivityType left, ApplicationGatewayWafRuleSensitivityType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ApplicationGatewayWafRuleSensitivityType"/>. </summary>
        public static implicit operator ApplicationGatewayWafRuleSensitivityType(string value) => new ApplicationGatewayWafRuleSensitivityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayWafRuleSensitivityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayWafRuleSensitivityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
