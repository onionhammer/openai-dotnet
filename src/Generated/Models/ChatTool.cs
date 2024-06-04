// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class ChatTool
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal ChatTool(ChatToolKind kind, InternalFunctionDefinition function, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Function = function;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal ChatTool()
        {
        }
    }
}
