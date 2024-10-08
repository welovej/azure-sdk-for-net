// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Type of the endpoint for the partner destination. </summary>
    internal readonly partial struct PartnerEndpointType : IEquatable<PartnerEndpointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PartnerEndpointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PartnerEndpointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebHookValue = "WebHook";

        /// <summary> WebHook. </summary>
        public static PartnerEndpointType WebHook { get; } = new PartnerEndpointType(WebHookValue);
        /// <summary> Determines if two <see cref="PartnerEndpointType"/> values are the same. </summary>
        public static bool operator ==(PartnerEndpointType left, PartnerEndpointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PartnerEndpointType"/> values are not the same. </summary>
        public static bool operator !=(PartnerEndpointType left, PartnerEndpointType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PartnerEndpointType"/>. </summary>
        public static implicit operator PartnerEndpointType(string value) => new PartnerEndpointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PartnerEndpointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PartnerEndpointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
