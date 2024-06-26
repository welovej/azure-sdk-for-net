// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Describes capacity information for a custom resource balancing metric. This can be used to limit the total consumption of this metric by the services of this application.
    ///
    /// </summary>
    public partial class ApplicationMetricDescription
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

        /// <summary> Initializes a new instance of <see cref="ApplicationMetricDescription"/>. </summary>
        public ApplicationMetricDescription()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationMetricDescription"/>. </summary>
        /// <param name="name"> The name of the metric. </param>
        /// <param name="maximumCapacity">
        /// The maximum node capacity for Service Fabric application.
        /// This is the maximum Load for an instance of this application on a single node. Even if the capacity of node is greater than this value, Service Fabric will limit the total load of services within the application on each node to this value.
        /// If set to zero, capacity for this metric is unlimited on each node.
        /// When creating a new application with application capacity defined, the product of MaximumNodes and this value must always be smaller than or equal to TotalApplicationCapacity.
        /// When updating existing application with application capacity, the product of MaximumNodes and this value must always be smaller than or equal to TotalApplicationCapacity.
        ///
        /// </param>
        /// <param name="reservationCapacity">
        /// The node reservation capacity for Service Fabric application.
        /// This is the amount of load which is reserved on nodes which have instances of this application.
        /// If MinimumNodes is specified, then the product of these values will be the capacity reserved in the cluster for the application.
        /// If set to zero, no capacity is reserved for this metric.
        /// When setting application capacity or when updating application capacity; this value must be smaller than or equal to MaximumCapacity for each metric.
        ///
        /// </param>
        /// <param name="totalApplicationCapacity">
        /// The total metric capacity for Service Fabric application.
        /// This is the total metric capacity for this application in the cluster. Service Fabric will try to limit the sum of loads of services within the application to this value.
        /// When creating a new application with application capacity defined, the product of MaximumNodes and MaximumCapacity must always be smaller than or equal to this value.
        ///
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationMetricDescription(string name, long? maximumCapacity, long? reservationCapacity, long? totalApplicationCapacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            MaximumCapacity = maximumCapacity;
            ReservationCapacity = reservationCapacity;
            TotalApplicationCapacity = totalApplicationCapacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the metric. </summary>
        public string Name { get; set; }
        /// <summary>
        /// The maximum node capacity for Service Fabric application.
        /// This is the maximum Load for an instance of this application on a single node. Even if the capacity of node is greater than this value, Service Fabric will limit the total load of services within the application on each node to this value.
        /// If set to zero, capacity for this metric is unlimited on each node.
        /// When creating a new application with application capacity defined, the product of MaximumNodes and this value must always be smaller than or equal to TotalApplicationCapacity.
        /// When updating existing application with application capacity, the product of MaximumNodes and this value must always be smaller than or equal to TotalApplicationCapacity.
        ///
        /// </summary>
        public long? MaximumCapacity { get; set; }
        /// <summary>
        /// The node reservation capacity for Service Fabric application.
        /// This is the amount of load which is reserved on nodes which have instances of this application.
        /// If MinimumNodes is specified, then the product of these values will be the capacity reserved in the cluster for the application.
        /// If set to zero, no capacity is reserved for this metric.
        /// When setting application capacity or when updating application capacity; this value must be smaller than or equal to MaximumCapacity for each metric.
        ///
        /// </summary>
        public long? ReservationCapacity { get; set; }
        /// <summary>
        /// The total metric capacity for Service Fabric application.
        /// This is the total metric capacity for this application in the cluster. Service Fabric will try to limit the sum of loads of services within the application to this value.
        /// When creating a new application with application capacity defined, the product of MaximumNodes and MaximumCapacity must always be smaller than or equal to this value.
        ///
        /// </summary>
        public long? TotalApplicationCapacity { get; set; }
    }
}
