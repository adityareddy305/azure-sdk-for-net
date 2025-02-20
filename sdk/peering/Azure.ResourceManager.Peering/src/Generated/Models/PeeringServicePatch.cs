// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The PeeringServicePatch. </summary>
    public partial class PeeringServicePatch : PeeringResourceTagsPatch
    {
        /// <summary> Initializes a new instance of <see cref="PeeringServicePatch"/>. </summary>
        public PeeringServicePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PeeringServicePatch"/>. </summary>
        /// <param name="tags"> Gets or sets the tags, a dictionary of descriptors arm object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringServicePatch(IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(tags, serializedAdditionalRawData)
        {
        }
    }
}
