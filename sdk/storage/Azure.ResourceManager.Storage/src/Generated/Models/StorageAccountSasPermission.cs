// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p). </summary>
    public readonly partial struct StorageAccountSasPermission : IEquatable<StorageAccountSasPermission>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageAccountSasPermission"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageAccountSasPermission(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RValue = "r";
        private const string DValue = "d";
        private const string WValue = "w";
        private const string LValue = "l";
        private const string AValue = "a";
        private const string CValue = "c";
        private const string UValue = "u";
        private const string PValue = "p";

        /// <summary> r. </summary>
        public static StorageAccountSasPermission R { get; } = new StorageAccountSasPermission(RValue);
        /// <summary> d. </summary>
        public static StorageAccountSasPermission D { get; } = new StorageAccountSasPermission(DValue);
        /// <summary> w. </summary>
        public static StorageAccountSasPermission W { get; } = new StorageAccountSasPermission(WValue);
        /// <summary> l. </summary>
        public static StorageAccountSasPermission L { get; } = new StorageAccountSasPermission(LValue);
        /// <summary> a. </summary>
        public static StorageAccountSasPermission A { get; } = new StorageAccountSasPermission(AValue);
        /// <summary> c. </summary>
        public static StorageAccountSasPermission C { get; } = new StorageAccountSasPermission(CValue);
        /// <summary> u. </summary>
        public static StorageAccountSasPermission U { get; } = new StorageAccountSasPermission(UValue);
        /// <summary> p. </summary>
        public static StorageAccountSasPermission P { get; } = new StorageAccountSasPermission(PValue);
        /// <summary> Determines if two <see cref="StorageAccountSasPermission"/> values are the same. </summary>
        public static bool operator ==(StorageAccountSasPermission left, StorageAccountSasPermission right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageAccountSasPermission"/> values are not the same. </summary>
        public static bool operator !=(StorageAccountSasPermission left, StorageAccountSasPermission right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StorageAccountSasPermission"/>. </summary>
        public static implicit operator StorageAccountSasPermission(string value) => new StorageAccountSasPermission(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageAccountSasPermission other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageAccountSasPermission other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
