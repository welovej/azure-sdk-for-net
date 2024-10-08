// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The status of the port. </summary>
    public readonly partial struct JitNetworkAccessPortStatus : IEquatable<JitNetworkAccessPortStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPortStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JitNetworkAccessPortStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RevokedValue = "Revoked";
        private const string InitiatedValue = "Initiated";

        /// <summary> Revoked. </summary>
        public static JitNetworkAccessPortStatus Revoked { get; } = new JitNetworkAccessPortStatus(RevokedValue);
        /// <summary> Initiated. </summary>
        public static JitNetworkAccessPortStatus Initiated { get; } = new JitNetworkAccessPortStatus(InitiatedValue);
        /// <summary> Determines if two <see cref="JitNetworkAccessPortStatus"/> values are the same. </summary>
        public static bool operator ==(JitNetworkAccessPortStatus left, JitNetworkAccessPortStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JitNetworkAccessPortStatus"/> values are not the same. </summary>
        public static bool operator !=(JitNetworkAccessPortStatus left, JitNetworkAccessPortStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="JitNetworkAccessPortStatus"/>. </summary>
        public static implicit operator JitNetworkAccessPortStatus(string value) => new JitNetworkAccessPortStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JitNetworkAccessPortStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JitNetworkAccessPortStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
