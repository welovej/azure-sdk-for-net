// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Product Entity Base Parameters. </summary>
    public partial class ProductEntityBaseProperties
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProductEntityBaseProperties"/>. </summary>
        internal ProductEntityBaseProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProductEntityBaseProperties"/>. </summary>
        /// <param name="description"> Product description. May include HTML formatting tags. </param>
        /// <param name="terms"> Product terms of use. Developers trying to subscribe to the product will be presented and required to accept these terms before they can complete the subscription process. </param>
        /// <param name="isSubscriptionRequired"> Whether a product subscription is required for accessing APIs included in this product. If true, the product is referred to as "protected" and a valid subscription key is required for a request to an API included in the product to succeed. If false, the product is referred to as "open" and requests to an API included in the product can be made without a subscription key. If property is omitted when creating a new product it's value is assumed to be true. </param>
        /// <param name="isApprovalRequired"> whether subscription approval is required. If false, new subscriptions will be approved automatically enabling developers to call the product’s APIs immediately after subscribing. If true, administrators must manually approve the subscription before the developer can any of the product’s APIs. Can be present only if subscriptionRequired property is present and has a value of false. </param>
        /// <param name="subscriptionsLimit"> Whether the number of subscriptions a user can have to this product at the same time. Set to null or omit to allow unlimited per user subscriptions. Can be present only if subscriptionRequired property is present and has a value of false. </param>
        /// <param name="state"> whether product is published or not. Published products are discoverable by users of developer portal. Non published products are visible only to administrators. Default state of Product is notPublished. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProductEntityBaseProperties(string description, string terms, bool? isSubscriptionRequired, bool? isApprovalRequired, int? subscriptionsLimit, ApiManagementProductState? state, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            Terms = terms;
            IsSubscriptionRequired = isSubscriptionRequired;
            IsApprovalRequired = isApprovalRequired;
            SubscriptionsLimit = subscriptionsLimit;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Product description. May include HTML formatting tags. </summary>
        [WirePath("description")]
        public string Description { get; }
        /// <summary> Product terms of use. Developers trying to subscribe to the product will be presented and required to accept these terms before they can complete the subscription process. </summary>
        [WirePath("terms")]
        public string Terms { get; }
        /// <summary> Whether a product subscription is required for accessing APIs included in this product. If true, the product is referred to as "protected" and a valid subscription key is required for a request to an API included in the product to succeed. If false, the product is referred to as "open" and requests to an API included in the product can be made without a subscription key. If property is omitted when creating a new product it's value is assumed to be true. </summary>
        [WirePath("subscriptionRequired")]
        public bool? IsSubscriptionRequired { get; }
        /// <summary> whether subscription approval is required. If false, new subscriptions will be approved automatically enabling developers to call the product’s APIs immediately after subscribing. If true, administrators must manually approve the subscription before the developer can any of the product’s APIs. Can be present only if subscriptionRequired property is present and has a value of false. </summary>
        [WirePath("approvalRequired")]
        public bool? IsApprovalRequired { get; }
        /// <summary> Whether the number of subscriptions a user can have to this product at the same time. Set to null or omit to allow unlimited per user subscriptions. Can be present only if subscriptionRequired property is present and has a value of false. </summary>
        [WirePath("subscriptionsLimit")]
        public int? SubscriptionsLimit { get; }
        /// <summary> whether product is published or not. Published products are discoverable by users of developer portal. Non published products are visible only to administrators. Default state of Product is notPublished. </summary>
        [WirePath("state")]
        public ApiManagementProductState? State { get; }
    }
}
