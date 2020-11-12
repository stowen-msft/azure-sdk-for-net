// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The direction of the traffic. </summary>
    public readonly partial struct Direction : IEquatable<Direction>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Direction"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Direction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Inbound. </summary>
        public static Direction Inbound { get; } = new Direction(InboundValue);
        /// <summary> Outbound. </summary>
        public static Direction Outbound { get; } = new Direction(OutboundValue);
        /// <summary> Determines if two <see cref="Direction"/> values are the same. </summary>
        public static bool operator ==(Direction left, Direction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Direction"/> values are not the same. </summary>
        public static bool operator !=(Direction left, Direction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Direction"/>. </summary>
        public static implicit operator Direction(string value) => new Direction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Direction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Direction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
