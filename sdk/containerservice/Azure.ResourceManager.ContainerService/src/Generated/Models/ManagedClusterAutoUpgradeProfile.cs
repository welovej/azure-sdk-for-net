// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Auto upgrade profile for a managed cluster. </summary>
    public partial class ManagedClusterAutoUpgradeProfile
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAutoUpgradeProfile"/>. </summary>
        public ManagedClusterAutoUpgradeProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAutoUpgradeProfile"/>. </summary>
        /// <param name="upgradeChannel"> For more information see [setting the AKS cluster auto-upgrade channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel). </param>
        /// <param name="nodeOSUpgradeChannel"> Manner in which the OS on your nodes is updated. The default is NodeImage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterAutoUpgradeProfile(UpgradeChannel? upgradeChannel, ManagedClusterNodeOSUpgradeChannel? nodeOSUpgradeChannel, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UpgradeChannel = upgradeChannel;
            NodeOSUpgradeChannel = nodeOSUpgradeChannel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> For more information see [setting the AKS cluster auto-upgrade channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel). </summary>
        [WirePath("upgradeChannel")]
        public UpgradeChannel? UpgradeChannel { get; set; }
        /// <summary> Manner in which the OS on your nodes is updated. The default is NodeImage. </summary>
        [WirePath("nodeOSUpgradeChannel")]
        public ManagedClusterNodeOSUpgradeChannel? NodeOSUpgradeChannel { get; set; }
    }
}
