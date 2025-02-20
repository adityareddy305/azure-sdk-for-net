// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Level of workspace setup error. </summary>
    public readonly partial struct MachineLearningDiagnoseResultLevel : IEquatable<MachineLearningDiagnoseResultLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningDiagnoseResultLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningDiagnoseResultLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string InformationValue = "Information";

        /// <summary> Warning. </summary>
        public static MachineLearningDiagnoseResultLevel Warning { get; } = new MachineLearningDiagnoseResultLevel(WarningValue);
        /// <summary> Error. </summary>
        public static MachineLearningDiagnoseResultLevel Error { get; } = new MachineLearningDiagnoseResultLevel(ErrorValue);
        /// <summary> Information. </summary>
        public static MachineLearningDiagnoseResultLevel Information { get; } = new MachineLearningDiagnoseResultLevel(InformationValue);
        /// <summary> Determines if two <see cref="MachineLearningDiagnoseResultLevel"/> values are the same. </summary>
        public static bool operator ==(MachineLearningDiagnoseResultLevel left, MachineLearningDiagnoseResultLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningDiagnoseResultLevel"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningDiagnoseResultLevel left, MachineLearningDiagnoseResultLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MachineLearningDiagnoseResultLevel"/>. </summary>
        public static implicit operator MachineLearningDiagnoseResultLevel(string value) => new MachineLearningDiagnoseResultLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningDiagnoseResultLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningDiagnoseResultLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
