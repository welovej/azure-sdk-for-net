// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Metadata about the resource. </summary>
    public partial class DataCollectionRuleMetadata : DataCollectionRuleRelatedResourceMetadata
    {
        /// <summary> Initializes a new instance of <see cref="DataCollectionRuleMetadata"/>. </summary>
        internal DataCollectionRuleMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionRuleMetadata"/>. </summary>
        /// <param name="provisionedBy"> Azure offering managing this resource on-behalf-of customer. </param>
        /// <param name="provisionedByResourceId"> Resource Id of azure offering managing this resource on-behalf-of customer. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataCollectionRuleMetadata(string provisionedBy, string provisionedByResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(provisionedBy, provisionedByResourceId, serializedAdditionalRawData)
        {
        }
    }
}
