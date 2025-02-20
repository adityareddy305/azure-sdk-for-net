// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Represents the Area entity Metadata model. </summary>
    public partial class AreaMetadata : BaseMetadata
    {
        /// <summary> Initializes a new instance of <see cref="AreaMetadata"/>. </summary>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"> Unit of measure for area. </param>
        internal AreaMetadata(double value, AreaUnit unit)
        {
            MetadataKind = MetadataKind.AreaMetadata;
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="AreaMetadata"/>. </summary>
        /// <param name="metadataKind"> The entity Metadata object kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"> Unit of measure for area. </param>
        internal AreaMetadata(MetadataKind metadataKind, IDictionary<string, BinaryData> serializedAdditionalRawData, double value, AreaUnit unit) : base(metadataKind, serializedAdditionalRawData)
        {
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="AreaMetadata"/> for deserialization. </summary>
        internal AreaMetadata()
        {
        }

        /// <summary> The numeric value that the extracted text denotes. </summary>
        public double Value { get; }
        /// <summary> Unit of measure for area. </summary>
        public AreaUnit Unit { get; }
    }
}
