// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> List of stop sell offers and plans notifications. </summary>
    public partial class StopSellOffersPlansNotificationsResult
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

        /// <summary> Initializes a new instance of <see cref="StopSellOffersPlansNotificationsResult"/>. </summary>
        internal StopSellOffersPlansNotificationsResult()
        {
            Plans = new ChangeTrackingList<PlanNotificationDetails>();
            SubscriptionsIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="StopSellOffersPlansNotificationsResult"/>. </summary>
        /// <param name="offerId"> The offer id. </param>
        /// <param name="displayName"> The offer display name. </param>
        /// <param name="isEntireInStopSell"> A value indicating whether entire offer is in stop sell or only few of its plans. </param>
        /// <param name="messageCode"> The notification message code. </param>
        /// <param name="iconUri"> The icon url. </param>
        /// <param name="plans"> The list of removed plans notifications. </param>
        /// <param name="hasPublicContext"> True if the offer has public plans. </param>
        /// <param name="subscriptionsIds"> The subscriptions related to private plans. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StopSellOffersPlansNotificationsResult(string offerId, string displayName, bool? isEntireInStopSell, long? messageCode, Uri iconUri, IReadOnlyList<PlanNotificationDetails> plans, bool? hasPublicContext, IReadOnlyList<string> subscriptionsIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OfferId = offerId;
            DisplayName = displayName;
            IsEntireInStopSell = isEntireInStopSell;
            MessageCode = messageCode;
            IconUri = iconUri;
            Plans = plans;
            HasPublicContext = hasPublicContext;
            SubscriptionsIds = subscriptionsIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The offer id. </summary>
        public string OfferId { get; }
        /// <summary> The offer display name. </summary>
        public string DisplayName { get; }
        /// <summary> A value indicating whether entire offer is in stop sell or only few of its plans. </summary>
        public bool? IsEntireInStopSell { get; }
        /// <summary> The notification message code. </summary>
        public long? MessageCode { get; }
        /// <summary> The icon url. </summary>
        public Uri IconUri { get; }
        /// <summary> The list of removed plans notifications. </summary>
        public IReadOnlyList<PlanNotificationDetails> Plans { get; }
        /// <summary> True if the offer has public plans. </summary>
        public bool? HasPublicContext { get; }
        /// <summary> The subscriptions related to private plans. </summary>
        public IReadOnlyList<string> SubscriptionsIds { get; }
    }
}
