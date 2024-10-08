// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.CodeTransparency
{
    /// <summary> Possible statuses of the operation. </summary>
    public readonly partial struct OperationStatus : IEquatable<OperationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "running";
        private const string FailedValue = "failed";
        private const string SucceededValue = "succeeded";

        /// <summary> Operation is still running. </summary>
        public static OperationStatus Running { get; } = new OperationStatus(RunningValue);
        /// <summary> Operation failed. </summary>
        public static OperationStatus Failed { get; } = new OperationStatus(FailedValue);
        /// <summary> Operation succeeded. </summary>
        public static OperationStatus Succeeded { get; } = new OperationStatus(SucceededValue);
        /// <summary> Determines if two <see cref="OperationStatus"/> values are the same. </summary>
        public static bool operator ==(OperationStatus left, OperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationStatus"/> values are not the same. </summary>
        public static bool operator !=(OperationStatus left, OperationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OperationStatus"/>. </summary>
        public static implicit operator OperationStatus(string value) => new OperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
