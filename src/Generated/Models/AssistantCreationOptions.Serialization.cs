// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    public partial class AssistantCreationOptions : IJsonModel<AssistantCreationOptions>
    {
        void IJsonModel<AssistantCreationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssistantCreationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssistantCreationOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model);
            if (Optional.IsDefined(Name))
            {
                if (Name != null)
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsDefined(Instructions))
            {
                if (Instructions != null)
                {
                    writer.WritePropertyName("instructions"u8);
                    writer.WriteStringValue(Instructions);
                }
                else
                {
                    writer.WriteNull("instructions");
                }
            }
            if (Optional.IsCollectionDefined(Tools))
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (var item in Tools)
                {
                    writer.WriteObjectValue<ToolDefinition>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ToolResources))
            {
                if (ToolResources != null)
                {
                    writer.WritePropertyName("tool_resources"u8);
                    writer.WriteObjectValue<ToolResources>(ToolResources, options);
                }
                else
                {
                    writer.WriteNull("tool_resources");
                }
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                if (Metadata != null)
                {
                    writer.WritePropertyName("metadata"u8);
                    writer.WriteStartObject();
                    foreach (var item in Metadata)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("metadata");
                }
            }
            if (Optional.IsDefined(Temperature))
            {
                if (Temperature != null)
                {
                    writer.WritePropertyName("temperature"u8);
                    writer.WriteNumberValue(Temperature.Value);
                }
                else
                {
                    writer.WriteNull("temperature");
                }
            }
            if (Optional.IsDefined(NucleusSamplingFactor))
            {
                if (NucleusSamplingFactor != null)
                {
                    writer.WritePropertyName("top_p"u8);
                    writer.WriteNumberValue(NucleusSamplingFactor.Value);
                }
                else
                {
                    writer.WriteNull("top_p");
                }
            }
            if (Optional.IsDefined(ResponseFormat))
            {
                if (ResponseFormat != null)
                {
                    writer.WritePropertyName("response_format"u8);
                    writer.WriteObjectValue<AssistantResponseFormat>(ResponseFormat, options);
                }
                else
                {
                    writer.WriteNull("response_format");
                }
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

        AssistantCreationOptions IJsonModel<AssistantCreationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssistantCreationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssistantCreationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssistantCreationOptions(document.RootElement, options);
        }

        internal static AssistantCreationOptions DeserializeAssistantCreationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string model = default;
            string name = default;
            string description = default;
            string instructions = default;
            IList<ToolDefinition> tools = default;
            ToolResources toolResources = default;
            IDictionary<string, string> metadata = default;
            float? temperature = default;
            float? topP = default;
            AssistantResponseFormat responseFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instructions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instructions = null;
                        continue;
                    }
                    instructions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ToolDefinition> array = new List<ToolDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ToolDefinition.DeserializeToolDefinition(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (property.NameEquals("tool_resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        toolResources = null;
                        continue;
                    }
                    toolResources = Assistants.ToolResources.DeserializeToolResources(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        temperature = null;
                        continue;
                    }
                    temperature = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("top_p"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        topP = null;
                        continue;
                    }
                    topP = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("response_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        responseFormat = null;
                        continue;
                    }
                    responseFormat = AssistantResponseFormat.DeserializeAssistantResponseFormat(property.Value, options);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AssistantCreationOptions(
                model,
                name,
                description,
                instructions,
                tools ?? new ChangeTrackingList<ToolDefinition>(),
                toolResources,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                temperature,
                topP,
                responseFormat,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssistantCreationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssistantCreationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssistantCreationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        AssistantCreationOptions IPersistableModel<AssistantCreationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssistantCreationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssistantCreationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssistantCreationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssistantCreationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static AssistantCreationOptions FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAssistantCreationOptions(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
