// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    internal static partial class SearchQueryTypeExtensions
    {
        public static string ToSerialString(this SearchQueryType value) => value switch
        {
            SearchQueryType.Simple => "simple",
            SearchQueryType.Full => "full",
            SearchQueryType.Semantic => "semantic",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchQueryType value.")
        };

        public static SearchQueryType ToSearchQueryType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "simple")) return SearchQueryType.Simple;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "full")) return SearchQueryType.Full;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "semantic")) return SearchQueryType.Semantic;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchQueryType value.");
        }
    }
}
