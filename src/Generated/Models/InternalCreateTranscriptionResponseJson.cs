// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Audio
{
    internal partial class InternalCreateTranscriptionResponseJson
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalCreateTranscriptionResponseJson(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
        }

        internal InternalCreateTranscriptionResponseJson(string text, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCreateTranscriptionResponseJson()
        {
        }

        public string Text { get; }
    }
}
