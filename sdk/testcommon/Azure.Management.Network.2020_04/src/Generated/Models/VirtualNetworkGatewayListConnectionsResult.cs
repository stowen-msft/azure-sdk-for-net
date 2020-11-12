// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for the VirtualNetworkGatewayListConnections API service call. </summary>
    public partial class VirtualNetworkGatewayListConnectionsResult
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayListConnectionsResult. </summary>
        internal VirtualNetworkGatewayListConnectionsResult()
        {
            Value = new ChangeTrackingList<VirtualNetworkGatewayConnectionListEntity>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayListConnectionsResult. </summary>
        /// <param name="value"> A list of VirtualNetworkGatewayConnection resources that exists in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal VirtualNetworkGatewayListConnectionsResult(IReadOnlyList<VirtualNetworkGatewayConnectionListEntity> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of VirtualNetworkGatewayConnection resources that exists in a resource group. </summary>
        public IReadOnlyList<VirtualNetworkGatewayConnectionListEntity> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
