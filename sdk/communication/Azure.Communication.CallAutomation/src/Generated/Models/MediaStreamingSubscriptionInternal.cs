// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Media streaming Subscription Object. </summary>
    internal partial class MediaStreamingSubscriptionInternal
    {
        /// <summary> Initializes a new instance of <see cref="MediaStreamingSubscriptionInternal"/>. </summary>
        internal MediaStreamingSubscriptionInternal()
        {
            SubscribedContentTypes = new ChangeTrackingList<MediaStreamingContent>();
        }

        /// <summary> Initializes a new instance of <see cref="MediaStreamingSubscriptionInternal"/>. </summary>
        /// <param name="id"> Subscription Id. </param>
        /// <param name="state"> Media streaming subscription state. </param>
        /// <param name="subscribedContentTypes"> Subscribed media streaming content types. </param>
        internal MediaStreamingSubscriptionInternal(string id, MediaStreamingSubscriptionState? state, IReadOnlyList<MediaStreamingContent> subscribedContentTypes)
        {
            Id = id;
            State = state;
            SubscribedContentTypes = subscribedContentTypes;
        }

        /// <summary> Subscription Id. </summary>
        public string Id { get; }
        /// <summary> Media streaming subscription state. </summary>
        public MediaStreamingSubscriptionState? State { get; }
        /// <summary> Subscribed media streaming content types. </summary>
        public IReadOnlyList<MediaStreamingContent> SubscribedContentTypes { get; }
    }
}
