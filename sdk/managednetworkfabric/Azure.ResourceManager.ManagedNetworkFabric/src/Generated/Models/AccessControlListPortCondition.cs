// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Defines the port condition that needs to be matched. </summary>
    public partial class AccessControlListPortCondition : NetworkFabricPortCondition
    {
        /// <summary> Initializes a new instance of <see cref="AccessControlListPortCondition"/>. </summary>
        /// <param name="layer4Protocol"> Layer4 protocol type that needs to be matched. </param>
        public AccessControlListPortCondition(Layer4Protocol layer4Protocol) : base(layer4Protocol)
        {
            Flags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AccessControlListPortCondition"/>. </summary>
        /// <param name="portType"> Port type that needs to be matched. </param>
        /// <param name="layer4Protocol"> Layer4 protocol type that needs to be matched. </param>
        /// <param name="ports"> List of the Ports that need to be matched. </param>
        /// <param name="portGroupNames"> List of the port Group Names that need to be matched. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="flags"> List of protocol flags that need to be matched. </param>
        internal AccessControlListPortCondition(NetworkFabricPortType? portType, Layer4Protocol layer4Protocol, IList<string> ports, IList<string> portGroupNames, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> flags) : base(portType, layer4Protocol, ports, portGroupNames, serializedAdditionalRawData)
        {
            Flags = flags;
        }

        /// <summary> Initializes a new instance of <see cref="AccessControlListPortCondition"/> for deserialization. </summary>
        internal AccessControlListPortCondition()
        {
        }

        /// <summary> List of protocol flags that need to be matched. </summary>
        public IList<string> Flags { get; }
    }
}
