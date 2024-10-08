// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class MonitorProperties : IUtf8JsonSerializable, IJsonModel<MonitorProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MonitorProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(MonitoringStatus))
            {
                writer.WritePropertyName("monitoringStatus"u8);
                writer.WriteStringValue(MonitoringStatus.Value.ToString());
            }
            if (Optional.IsDefined(ElasticProperties))
            {
                writer.WritePropertyName("elasticProperties"u8);
                writer.WriteObjectValue(ElasticProperties, options);
            }
            if (Optional.IsDefined(UserInfo))
            {
                writer.WritePropertyName("userInfo"u8);
                writer.WriteObjectValue(UserInfo, options);
            }
            if (Optional.IsDefined(PlanDetails))
            {
                writer.WritePropertyName("planDetails"u8);
                writer.WriteObjectValue(PlanDetails, options);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(SubscriptionState))
            {
                writer.WritePropertyName("subscriptionState"u8);
                writer.WriteStringValue(SubscriptionState);
            }
            if (Optional.IsDefined(SaaSAzureSubscriptionStatus))
            {
                writer.WritePropertyName("saaSAzureSubscriptionStatus"u8);
                writer.WriteStringValue(SaaSAzureSubscriptionStatus);
            }
            if (Optional.IsDefined(SourceCampaignName))
            {
                writer.WritePropertyName("sourceCampaignName"u8);
                writer.WriteStringValue(SourceCampaignName);
            }
            if (Optional.IsDefined(SourceCampaignId))
            {
                writer.WritePropertyName("sourceCampaignId"u8);
                writer.WriteStringValue(SourceCampaignId);
            }
            if (options.Format != "W" && Optional.IsDefined(LiftrResourceCategory))
            {
                writer.WritePropertyName("liftrResourceCategory"u8);
                writer.WriteStringValue(LiftrResourceCategory.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LiftrResourcePreference))
            {
                writer.WritePropertyName("liftrResourcePreference"u8);
                writer.WriteNumberValue(LiftrResourcePreference.Value);
            }
            if (Optional.IsDefined(GenerateApiKey))
            {
                writer.WritePropertyName("generateApiKey"u8);
                writer.WriteBooleanValue(GenerateApiKey.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        MonitorProperties IJsonModel<MonitorProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorProperties(document.RootElement, options);
        }

        internal static MonitorProperties DeserializeMonitorProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            MonitoringStatus? monitoringStatus = default;
            ElasticProperties elasticProperties = default;
            UserInfo userInfo = default;
            PlanDetails planDetails = default;
            string version = default;
            string subscriptionState = default;
            string saaSAzureSubscriptionStatus = default;
            string sourceCampaignName = default;
            string sourceCampaignId = default;
            LiftrResourceCategory? liftrResourceCategory = default;
            int? liftrResourcePreference = default;
            bool? generateApiKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitoringStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringStatus = new MonitoringStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("elasticProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elasticProperties = ElasticProperties.DeserializeElasticProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userInfo = UserInfo.DeserializeUserInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("planDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    planDetails = PlanDetails.DeserializePlanDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionState"u8))
                {
                    subscriptionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("saaSAzureSubscriptionStatus"u8))
                {
                    saaSAzureSubscriptionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCampaignName"u8))
                {
                    sourceCampaignName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCampaignId"u8))
                {
                    sourceCampaignId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("liftrResourceCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    liftrResourceCategory = new LiftrResourceCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("liftrResourcePreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    liftrResourcePreference = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("generateApiKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    generateApiKey = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MonitorProperties(
                provisioningState,
                monitoringStatus,
                elasticProperties,
                userInfo,
                planDetails,
                version,
                subscriptionState,
                saaSAzureSubscriptionStatus,
                sourceCampaignName,
                sourceCampaignId,
                liftrResourceCategory,
                liftrResourcePreference,
                generateApiKey,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MonitorProperties IPersistableModel<MonitorProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
