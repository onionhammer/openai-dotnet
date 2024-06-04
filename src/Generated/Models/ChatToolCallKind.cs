// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat
{
    public readonly partial struct ChatToolCallKind : IEquatable<ChatToolCallKind>
    {
        private readonly string _value;

        public ChatToolCallKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FunctionValue = "function";

        public static ChatToolCallKind Function { get; } = new ChatToolCallKind(FunctionValue);
        public static bool operator ==(ChatToolCallKind left, ChatToolCallKind right) => left.Equals(right);
        public static bool operator !=(ChatToolCallKind left, ChatToolCallKind right) => !left.Equals(right);
        public static implicit operator ChatToolCallKind(string value) => new ChatToolCallKind(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChatToolCallKind other && Equals(other);
        public bool Equals(ChatToolCallKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
