// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Sets correlation protocol to use for Application Insights diagnostics. </summary>
    public readonly partial struct HttpCorrelationProtocol : IEquatable<HttpCorrelationProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HttpCorrelationProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HttpCorrelationProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string LegacyValue = "Legacy";
        private const string W3CValue = "W3C";

        /// <summary> Do not read and inject correlation headers. </summary>
        public static HttpCorrelationProtocol None { get; } = new HttpCorrelationProtocol(NoneValue);
        /// <summary> Inject Request-Id and Request-Context headers with request correlation data. See https://github.com/dotnet/corefx/blob/master/src/System.Diagnostics.DiagnosticSource/src/HttpCorrelationProtocol.md. </summary>
        public static HttpCorrelationProtocol Legacy { get; } = new HttpCorrelationProtocol(LegacyValue);
        /// <summary> Inject Trace Context headers. See https://w3c.github.io/trace-context. </summary>
        public static HttpCorrelationProtocol W3C { get; } = new HttpCorrelationProtocol(W3CValue);
        /// <summary> Determines if two <see cref="HttpCorrelationProtocol"/> values are the same. </summary>
        public static bool operator ==(HttpCorrelationProtocol left, HttpCorrelationProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HttpCorrelationProtocol"/> values are not the same. </summary>
        public static bool operator !=(HttpCorrelationProtocol left, HttpCorrelationProtocol right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HttpCorrelationProtocol"/>. </summary>
        public static implicit operator HttpCorrelationProtocol(string value) => new HttpCorrelationProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HttpCorrelationProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HttpCorrelationProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
