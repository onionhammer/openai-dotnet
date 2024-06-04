// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Audio
{
    internal readonly partial struct InternalCreateSpeechRequestModel : IEquatable<InternalCreateSpeechRequestModel>
    {
        private readonly string _value;

        public InternalCreateSpeechRequestModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Tts1Value = "tts-1";
        private const string Tts1HdValue = "tts-1-hd";

        public static InternalCreateSpeechRequestModel Tts1 { get; } = new InternalCreateSpeechRequestModel(Tts1Value);
        public static InternalCreateSpeechRequestModel Tts1Hd { get; } = new InternalCreateSpeechRequestModel(Tts1HdValue);
        public static bool operator ==(InternalCreateSpeechRequestModel left, InternalCreateSpeechRequestModel right) => left.Equals(right);
        public static bool operator !=(InternalCreateSpeechRequestModel left, InternalCreateSpeechRequestModel right) => !left.Equals(right);
        public static implicit operator InternalCreateSpeechRequestModel(string value) => new InternalCreateSpeechRequestModel(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateSpeechRequestModel other && Equals(other);
        public bool Equals(InternalCreateSpeechRequestModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
