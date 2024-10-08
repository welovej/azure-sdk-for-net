// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Whois information for a given domain and associated metadata. </summary>
    public partial class EnrichmentDomainWhois
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

        /// <summary> Initializes a new instance of <see cref="EnrichmentDomainWhois"/>. </summary>
        internal EnrichmentDomainWhois()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EnrichmentDomainWhois"/>. </summary>
        /// <param name="domain"> The domain for this whois record. </param>
        /// <param name="server"> The hostname of this registrar's whois server. </param>
        /// <param name="created"> The timestamp at which this record was created. </param>
        /// <param name="updatedOn"> The timestamp at which this record was last updated. </param>
        /// <param name="expireOn"> The timestamp at which this record will expire. </param>
        /// <param name="parsedWhois"> The whois record for a given domain. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnrichmentDomainWhois(string domain, string server, DateTimeOffset? created, DateTimeOffset? updatedOn, DateTimeOffset? expireOn, EnrichmentDomainWhoisDetails parsedWhois, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Domain = domain;
            Server = server;
            Created = created;
            UpdatedOn = updatedOn;
            ExpireOn = expireOn;
            ParsedWhois = parsedWhois;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The domain for this whois record. </summary>
        [WirePath("domain")]
        public string Domain { get; }
        /// <summary> The hostname of this registrar's whois server. </summary>
        [WirePath("server")]
        public string Server { get; }
        /// <summary> The timestamp at which this record was created. </summary>
        [WirePath("created")]
        public DateTimeOffset? Created { get; }
        /// <summary> The timestamp at which this record was last updated. </summary>
        [WirePath("updated")]
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> The timestamp at which this record will expire. </summary>
        [WirePath("expires")]
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> The whois record for a given domain. </summary>
        [WirePath("parsedWhois")]
        public EnrichmentDomainWhoisDetails ParsedWhois { get; }
    }
}
