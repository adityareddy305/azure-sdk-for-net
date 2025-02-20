// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Notification update request payload. </summary>
    public partial class AcknowledgeOfferNotificationContent
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

        /// <summary> Initializes a new instance of <see cref="AcknowledgeOfferNotificationContent"/>. </summary>
        public AcknowledgeOfferNotificationContent()
        {
            AddPlans = new ChangeTrackingList<string>();
            RemovePlans = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AcknowledgeOfferNotificationContent"/>. </summary>
        /// <param name="isAcknowledgeActionFlagEnabled"> Gets or sets a value indicating whether acknowledge action flag is enabled. </param>
        /// <param name="isDismissActionFlagEnabled"> Gets or sets a value indicating whether dismiss action flag is enabled. </param>
        /// <param name="isRemoveOfferActionFlagEnabled"> Gets or sets a value indicating whether remove offer action flag is enabled. </param>
        /// <param name="addPlans"> Gets or sets added plans. </param>
        /// <param name="removePlans"> Gets or sets remove plans. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcknowledgeOfferNotificationContent(bool? isAcknowledgeActionFlagEnabled, bool? isDismissActionFlagEnabled, bool? isRemoveOfferActionFlagEnabled, IList<string> addPlans, IList<string> removePlans, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsAcknowledgeActionFlagEnabled = isAcknowledgeActionFlagEnabled;
            IsDismissActionFlagEnabled = isDismissActionFlagEnabled;
            IsRemoveOfferActionFlagEnabled = isRemoveOfferActionFlagEnabled;
            AddPlans = addPlans;
            RemovePlans = removePlans;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets a value indicating whether acknowledge action flag is enabled. </summary>
        public bool? IsAcknowledgeActionFlagEnabled { get; set; }
        /// <summary> Gets or sets a value indicating whether dismiss action flag is enabled. </summary>
        public bool? IsDismissActionFlagEnabled { get; set; }
        /// <summary> Gets or sets a value indicating whether remove offer action flag is enabled. </summary>
        public bool? IsRemoveOfferActionFlagEnabled { get; set; }
        /// <summary> Gets or sets added plans. </summary>
        public IList<string> AddPlans { get; }
        /// <summary> Gets or sets remove plans. </summary>
        public IList<string> RemovePlans { get; }
    }
}
