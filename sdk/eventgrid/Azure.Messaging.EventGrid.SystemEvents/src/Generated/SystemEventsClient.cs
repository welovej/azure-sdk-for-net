// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    // Data plane generated client.
    /// <summary> The SystemEvents service client. </summary>
    internal partial class SystemEventsClient
    {
        private readonly HttpPipeline _pipeline;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SystemEventsClient. </summary>
        public SystemEventsClient() : this(new SystemEventsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of SystemEventsClient. </summary>
        /// <param name="options"> The options for configuring the client. </param>
        public SystemEventsClient(SystemEventsClientOptions options)
        {
            options ??= new SystemEventsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
        }
    }
}
