// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Hci
{
    internal class LogicalNetworkOperationSource : IOperationSource<LogicalNetworkResource>
    {
        private readonly ArmClient _client;

        internal LogicalNetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        LogicalNetworkResource IOperationSource<LogicalNetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LogicalNetworkData.DeserializeLogicalNetworkData(document.RootElement);
            return new LogicalNetworkResource(_client, data);
        }

        async ValueTask<LogicalNetworkResource> IOperationSource<LogicalNetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LogicalNetworkData.DeserializeLogicalNetworkData(document.RootElement);
            return new LogicalNetworkResource(_client, data);
        }
    }
}
