// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The private link service connection state. </summary>
    public partial class PurviewPrivateLinkServiceConnectionState
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

        /// <summary> Initializes a new instance of <see cref="PurviewPrivateLinkServiceConnectionState"/>. </summary>
        public PurviewPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="actionsRequired"> The required actions. </param>
        /// <param name="description"> The description. </param>
        /// <param name="status"> The status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewPrivateLinkServiceConnectionState(string actionsRequired, string description, PurviewPrivateLinkServiceStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionsRequired = actionsRequired;
            Description = description;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The required actions. </summary>
        public string ActionsRequired { get; set; }
        /// <summary> The description. </summary>
        public string Description { get; set; }
        /// <summary> The status. </summary>
        public PurviewPrivateLinkServiceStatus? Status { get; set; }
    }
}
