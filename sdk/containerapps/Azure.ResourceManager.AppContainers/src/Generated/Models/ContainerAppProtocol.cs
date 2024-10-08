// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http. </summary>
    public readonly partial struct ContainerAppProtocol : IEquatable<ContainerAppProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "http";
        private const string GrpcValue = "grpc";

        /// <summary> http. </summary>
        public static ContainerAppProtocol Http { get; } = new ContainerAppProtocol(HttpValue);
        /// <summary> grpc. </summary>
        public static ContainerAppProtocol Grpc { get; } = new ContainerAppProtocol(GrpcValue);
        /// <summary> Determines if two <see cref="ContainerAppProtocol"/> values are the same. </summary>
        public static bool operator ==(ContainerAppProtocol left, ContainerAppProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppProtocol"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppProtocol left, ContainerAppProtocol right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerAppProtocol"/>. </summary>
        public static implicit operator ContainerAppProtocol(string value) => new ContainerAppProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
