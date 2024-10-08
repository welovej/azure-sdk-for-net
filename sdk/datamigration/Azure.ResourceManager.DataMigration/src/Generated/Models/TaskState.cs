// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The state of the task. This is ignored if submitted. </summary>
    public readonly partial struct TaskState : IEquatable<TaskState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TaskState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TaskState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string QueuedValue = "Queued";
        private const string RunningValue = "Running";
        private const string CanceledValue = "Canceled";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string FailedInputValidationValue = "FailedInputValidation";
        private const string FaultedValue = "Faulted";

        /// <summary> Unknown. </summary>
        public static TaskState Unknown { get; } = new TaskState(UnknownValue);
        /// <summary> Queued. </summary>
        public static TaskState Queued { get; } = new TaskState(QueuedValue);
        /// <summary> Running. </summary>
        public static TaskState Running { get; } = new TaskState(RunningValue);
        /// <summary> Canceled. </summary>
        public static TaskState Canceled { get; } = new TaskState(CanceledValue);
        /// <summary> Succeeded. </summary>
        public static TaskState Succeeded { get; } = new TaskState(SucceededValue);
        /// <summary> Failed. </summary>
        public static TaskState Failed { get; } = new TaskState(FailedValue);
        /// <summary> FailedInputValidation. </summary>
        public static TaskState FailedInputValidation { get; } = new TaskState(FailedInputValidationValue);
        /// <summary> Faulted. </summary>
        public static TaskState Faulted { get; } = new TaskState(FaultedValue);
        /// <summary> Determines if two <see cref="TaskState"/> values are the same. </summary>
        public static bool operator ==(TaskState left, TaskState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TaskState"/> values are not the same. </summary>
        public static bool operator !=(TaskState left, TaskState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TaskState"/>. </summary>
        public static implicit operator TaskState(string value) => new TaskState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TaskState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TaskState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
