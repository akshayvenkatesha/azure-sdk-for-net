// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// A standard service response including an HTTP status code and request
    /// ID.
    /// </summary>
    public partial class GatewayConnectionGetResponse : AzureOperationResponse
    {
        private string _connectedEntityId;
        
        /// <summary>
        /// Optional. The Service Key / Local network gateway Id / Vnet Network
        /// Gateway Id.
        /// </summary>
        public string ConnectedEntityId
        {
            get { return this._connectedEntityId; }
            set { this._connectedEntityId = value; }
        }
        
        private bool _enableBgp;
        
        /// <summary>
        /// Optional. Whether BGP is enabled for this connection
        /// </summary>
        public bool EnableBgp
        {
            get { return this._enableBgp; }
            set { this._enableBgp = value; }
        }
        
        private string _gatewayConnectionName;
        
        /// <summary>
        /// Optional. The name of the virtual network gateway connection.
        /// </summary>
        public string GatewayConnectionName
        {
            get { return this._gatewayConnectionName; }
            set { this._gatewayConnectionName = value; }
        }
        
        private string _gatewayConnectionType;
        
        /// <summary>
        /// Optional. The connection type of gateway:
        /// Ipsec/Dedicated/VpnClient/Vnet2Vnet.
        /// </summary>
        public string GatewayConnectionType
        {
            get { return this._gatewayConnectionType; }
            set { this._gatewayConnectionType = value; }
        }
        
        private int _routingWeight;
        
        /// <summary>
        /// Optional. The Routing Weight.
        /// </summary>
        public int RoutingWeight
        {
            get { return this._routingWeight; }
            set { this._routingWeight = value; }
        }
        
        private string _sharedKey;
        
        /// <summary>
        /// Optional. The Ipsec share key.
        /// </summary>
        public string SharedKey
        {
            get { return this._sharedKey; }
            set { this._sharedKey = value; }
        }
        
        private Guid _virtualNetworkGatewayId;
        
        /// <summary>
        /// Optional. The Virtual network gateway Id.
        /// </summary>
        public Guid VirtualNetworkGatewayId
        {
            get { return this._virtualNetworkGatewayId; }
            set { this._virtualNetworkGatewayId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GatewayConnectionGetResponse
        /// class.
        /// </summary>
        public GatewayConnectionGetResponse()
        {
        }
    }
}
