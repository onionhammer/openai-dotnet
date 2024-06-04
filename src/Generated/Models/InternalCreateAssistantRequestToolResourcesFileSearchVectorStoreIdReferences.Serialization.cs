// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences : IJsonModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>
    {
        void IJsonModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VectorStoreIds))
            {
                writer.WritePropertyName("vector_store_ids"u8);
                writer.WriteStartArray();
                foreach (var item in VectorStoreIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (true && _serializedAdditionalRawData != null)
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
            writer.WriteEndObject();
        }

        InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences IJsonModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences(document.RootElement, options);
        }

        internal static InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences DeserializeInternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> vectorStoreIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vector_store_ids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vectorStoreIds = array;
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences(vectorStoreIds ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences IPersistableModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCreateAssistantRequestToolResourcesFileSearchVectorStoreIdReferences(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
