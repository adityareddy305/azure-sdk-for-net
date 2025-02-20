// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The AutomationRulePropertyChangedConditionSupportedChangedType. </summary>
    public readonly partial struct AutomationRulePropertyChangedConditionSupportedChangedType : IEquatable<AutomationRulePropertyChangedConditionSupportedChangedType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationRulePropertyChangedConditionSupportedChangedType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationRulePropertyChangedConditionSupportedChangedType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ChangedFromValue = "ChangedFrom";
        private const string ChangedToValue = "ChangedTo";

        /// <summary> Evaluate the condition on the previous value of the property. </summary>
        public static AutomationRulePropertyChangedConditionSupportedChangedType ChangedFrom { get; } = new AutomationRulePropertyChangedConditionSupportedChangedType(ChangedFromValue);
        /// <summary> Evaluate the condition on the updated value of the property. </summary>
        public static AutomationRulePropertyChangedConditionSupportedChangedType ChangedTo { get; } = new AutomationRulePropertyChangedConditionSupportedChangedType(ChangedToValue);
        /// <summary> Determines if two <see cref="AutomationRulePropertyChangedConditionSupportedChangedType"/> values are the same. </summary>
        public static bool operator ==(AutomationRulePropertyChangedConditionSupportedChangedType left, AutomationRulePropertyChangedConditionSupportedChangedType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationRulePropertyChangedConditionSupportedChangedType"/> values are not the same. </summary>
        public static bool operator !=(AutomationRulePropertyChangedConditionSupportedChangedType left, AutomationRulePropertyChangedConditionSupportedChangedType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AutomationRulePropertyChangedConditionSupportedChangedType"/>. </summary>
        public static implicit operator AutomationRulePropertyChangedConditionSupportedChangedType(string value) => new AutomationRulePropertyChangedConditionSupportedChangedType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationRulePropertyChangedConditionSupportedChangedType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationRulePropertyChangedConditionSupportedChangedType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
