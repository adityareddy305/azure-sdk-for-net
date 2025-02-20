// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Message Interactive list reply content for a user to business message. </summary>
    public partial class AcsMessageInteractiveListReplyContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AcsMessageInteractiveListReplyContent"/>. </summary>
        internal AcsMessageInteractiveListReplyContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageInteractiveListReplyContent"/>. </summary>
        /// <param name="listItemId"> The ID of the selected list item. </param>
        /// <param name="title"> The title of the selected list item. </param>
        /// <param name="description"> The description of the selected row. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsMessageInteractiveListReplyContent(string listItemId, string title, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ListItemId = listItemId;
            Title = title;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the selected list item. </summary>
        public string ListItemId { get; }
        /// <summary> The title of the selected list item. </summary>
        public string Title { get; }
        /// <summary> The description of the selected row. </summary>
        public string Description { get; }
    }
}
