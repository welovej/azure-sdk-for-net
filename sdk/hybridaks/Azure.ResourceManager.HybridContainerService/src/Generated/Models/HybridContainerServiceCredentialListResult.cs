// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The list kubeconfig result response. </summary>
    public partial class HybridContainerServiceCredentialListResult
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

        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceCredentialListResult"/>. </summary>
        internal HybridContainerServiceCredentialListResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceCredentialListResult"/>. </summary>
        /// <param name="id"> Operation Id. </param>
        /// <param name="name"> Operation Name. </param>
        /// <param name="resourceId"> ARM Resource Id of the provisioned cluster instance. </param>
        /// <param name="status"> Provisioning state of the resource. </param>
        /// <param name="error"></param>
        /// <param name="properties"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridContainerServiceCredentialListResult(string id, string name, ResourceIdentifier resourceId, HybridContainerServiceResourceProvisioningState? status, HybridContainerServiceCredentialListError error, ListCredentialResponseProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            ResourceId = resourceId;
            Status = status;
            Error = error;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Operation Id. </summary>
        public string Id { get; }
        /// <summary> Operation Name. </summary>
        public string Name { get; }
        /// <summary> ARM Resource Id of the provisioned cluster instance. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public HybridContainerServiceResourceProvisioningState? Status { get; }
        /// <summary> Gets the error. </summary>
        public HybridContainerServiceCredentialListError Error { get; }
        /// <summary> Gets the properties. </summary>
        internal ListCredentialResponseProperties Properties { get; }
        /// <summary> Base64-encoded Kubernetes configuration file. </summary>
        public IReadOnlyList<HybridContainerServiceCredential> ListCredentialResponseKubeconfigs
        {
            get => Properties?.Kubeconfigs;
        }
    }
}
