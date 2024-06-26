// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The ReputationDetails. </summary>
    public partial class ReputationDetails
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

        /// <summary> Initializes a new instance of <see cref="ReputationDetails"/>. </summary>
        internal ReputationDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReputationDetails"/>. </summary>
        /// <param name="listName"></param>
        /// <param name="threatType"></param>
        /// <param name="trusted"></param>
        /// <param name="cidr"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="listUpdatedAt"></param>
        /// <param name="recent"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReputationDetails(string listName, string threatType, bool? trusted, string cidr, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, DateTimeOffset? listUpdatedAt, bool? recent, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ListName = listName;
            ThreatType = threatType;
            Trusted = trusted;
            Cidr = cidr;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            ListUpdatedAt = listUpdatedAt;
            Recent = recent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the list name. </summary>
        public string ListName { get; }
        /// <summary> Gets the threat type. </summary>
        public string ThreatType { get; }
        /// <summary> Gets the trusted. </summary>
        public bool? Trusted { get; }
        /// <summary> Gets the cidr. </summary>
        public string Cidr { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the list updated at. </summary>
        public DateTimeOffset? ListUpdatedAt { get; }
        /// <summary> Gets the recent. </summary>
        public bool? Recent { get; }
    }
}
