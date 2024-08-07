// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    /// <summary> Metadata Serverless Config Properties. </summary>
    public partial class ServerlessConfigProperties
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

        /// <summary> Initializes a new instance of <see cref="ServerlessConfigProperties"/>. </summary>
        internal ServerlessConfigProperties()
        {
            ApplicationTypes = new ChangeTrackingList<InformaticaApplicationTypeMetadata>();
            ComputeUnits = new ChangeTrackingList<ComputeUnitsMetadata>();
            Regions = new ChangeTrackingList<InformaticaRegionsMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="ServerlessConfigProperties"/>. </summary>
        /// <param name="platform"> Platform types. </param>
        /// <param name="applicationTypes"> List of application types supported by informatica. </param>
        /// <param name="computeUnits"> The list of compute units with possible array of values. </param>
        /// <param name="executionTimeout"> Serverless Runtime execution timeout. </param>
        /// <param name="regions"> List of supported serverless informatica regions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerlessConfigProperties(InformaticaPlatformType? platform, IReadOnlyList<InformaticaApplicationTypeMetadata> applicationTypes, IReadOnlyList<ComputeUnitsMetadata> computeUnits, string executionTimeout, IReadOnlyList<InformaticaRegionsMetadata> regions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Platform = platform;
            ApplicationTypes = applicationTypes;
            ComputeUnits = computeUnits;
            ExecutionTimeout = executionTimeout;
            Regions = regions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Platform types. </summary>
        public InformaticaPlatformType? Platform { get; }
        /// <summary> List of application types supported by informatica. </summary>
        public IReadOnlyList<InformaticaApplicationTypeMetadata> ApplicationTypes { get; }
        /// <summary> The list of compute units with possible array of values. </summary>
        public IReadOnlyList<ComputeUnitsMetadata> ComputeUnits { get; }
        /// <summary> Serverless Runtime execution timeout. </summary>
        public string ExecutionTimeout { get; }
        /// <summary> List of supported serverless informatica regions. </summary>
        public IReadOnlyList<InformaticaRegionsMetadata> Regions { get; }
    }
}
