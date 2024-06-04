// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat
{
    internal readonly partial struct InternalChatCompletionRequestMessageContentPartTextType : IEquatable<InternalChatCompletionRequestMessageContentPartTextType>
    {
        private readonly string _value;

        public InternalChatCompletionRequestMessageContentPartTextType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";

        public static InternalChatCompletionRequestMessageContentPartTextType Text { get; } = new InternalChatCompletionRequestMessageContentPartTextType(TextValue);
        public static bool operator ==(InternalChatCompletionRequestMessageContentPartTextType left, InternalChatCompletionRequestMessageContentPartTextType right) => left.Equals(right);
        public static bool operator !=(InternalChatCompletionRequestMessageContentPartTextType left, InternalChatCompletionRequestMessageContentPartTextType right) => !left.Equals(right);
        public static implicit operator InternalChatCompletionRequestMessageContentPartTextType(string value) => new InternalChatCompletionRequestMessageContentPartTextType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalChatCompletionRequestMessageContentPartTextType other && Equals(other);
        public bool Equals(InternalChatCompletionRequestMessageContentPartTextType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
