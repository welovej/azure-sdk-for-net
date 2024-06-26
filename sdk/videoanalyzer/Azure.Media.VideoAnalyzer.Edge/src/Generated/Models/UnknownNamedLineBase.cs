// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Unknown version of NamedLineBase. </summary>
    internal partial class UnknownNamedLineBase : NamedLineBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownNamedLineBase"/>. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="name"> Line name. Must be unique within the node. </param>
        internal UnknownNamedLineBase(string type, string name) : base(type, name)
        {
            Type = type ?? "Unknown";
        }
    }
}
