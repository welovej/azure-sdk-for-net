// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The protocol associated with the port. </summary>
    public readonly partial struct ContainerNetworkProtocol : IEquatable<ContainerNetworkProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerNetworkProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerNetworkProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "TCP";
        private const string UdpValue = "UDP";

        /// <summary> TCP. </summary>
        public static ContainerNetworkProtocol Tcp { get; } = new ContainerNetworkProtocol(TcpValue);
        /// <summary> UDP. </summary>
        public static ContainerNetworkProtocol Udp { get; } = new ContainerNetworkProtocol(UdpValue);
        /// <summary> Determines if two <see cref="ContainerNetworkProtocol"/> values are the same. </summary>
        public static bool operator ==(ContainerNetworkProtocol left, ContainerNetworkProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerNetworkProtocol"/> values are not the same. </summary>
        public static bool operator !=(ContainerNetworkProtocol left, ContainerNetworkProtocol right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerNetworkProtocol"/>. </summary>
        public static implicit operator ContainerNetworkProtocol(string value) => new ContainerNetworkProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerNetworkProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerNetworkProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
