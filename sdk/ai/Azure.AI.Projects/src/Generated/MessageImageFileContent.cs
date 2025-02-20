// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> A representation of image file content in a thread message. </summary>
    public partial class MessageImageFileContent : MessageContent
    {
        /// <summary> Initializes a new instance of <see cref="MessageImageFileContent"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalDetails"> The image file for this thread message content item. </param>
        internal MessageImageFileContent(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalMessageImageFileDetails internalDetails) : base(type, serializedAdditionalRawData)
        {
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MessageImageFileContent"/> for deserialization. </summary>
        internal MessageImageFileContent()
        {
        }
    }
}
