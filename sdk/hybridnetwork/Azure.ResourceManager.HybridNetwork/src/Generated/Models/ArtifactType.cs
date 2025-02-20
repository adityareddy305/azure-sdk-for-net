// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The artifact type. </summary>
    public readonly partial struct ArtifactType : IEquatable<ArtifactType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArtifactType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArtifactType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string OCIArtifactValue = "OCIArtifact";
        private const string VhdImageFileValue = "VhdImageFile";
        private const string ArmTemplateValue = "ArmTemplate";
        private const string ImageFileValue = "ImageFile";

        /// <summary> Unknown. </summary>
        public static ArtifactType Unknown { get; } = new ArtifactType(UnknownValue);
        /// <summary> OCIArtifact. </summary>
        public static ArtifactType OCIArtifact { get; } = new ArtifactType(OCIArtifactValue);
        /// <summary> VhdImageFile. </summary>
        public static ArtifactType VhdImageFile { get; } = new ArtifactType(VhdImageFileValue);
        /// <summary> ArmTemplate. </summary>
        public static ArtifactType ArmTemplate { get; } = new ArtifactType(ArmTemplateValue);
        /// <summary> ImageFile. </summary>
        public static ArtifactType ImageFile { get; } = new ArtifactType(ImageFileValue);
        /// <summary> Determines if two <see cref="ArtifactType"/> values are the same. </summary>
        public static bool operator ==(ArtifactType left, ArtifactType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArtifactType"/> values are not the same. </summary>
        public static bool operator !=(ArtifactType left, ArtifactType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ArtifactType"/>. </summary>
        public static implicit operator ArtifactType(string value) => new ArtifactType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArtifactType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArtifactType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
