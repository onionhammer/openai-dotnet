// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Batch
{
    internal readonly partial struct InternalListBatchesResponseObject : IEquatable<InternalListBatchesResponseObject>
    {
        private readonly string _value;

        public InternalListBatchesResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        public static InternalListBatchesResponseObject List { get; } = new InternalListBatchesResponseObject(ListValue);
        public static bool operator ==(InternalListBatchesResponseObject left, InternalListBatchesResponseObject right) => left.Equals(right);
        public static bool operator !=(InternalListBatchesResponseObject left, InternalListBatchesResponseObject right) => !left.Equals(right);
        public static implicit operator InternalListBatchesResponseObject(string value) => new InternalListBatchesResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalListBatchesResponseObject other && Equals(other);
        public bool Equals(InternalListBatchesResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
