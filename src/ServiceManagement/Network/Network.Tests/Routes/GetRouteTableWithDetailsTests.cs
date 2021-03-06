﻿// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Network.Tests.Routes
{
    using System.Net;
    using Microsoft.WindowsAzure.Management.Network.Models;
    using Xunit;

    public class GetRouteTableWithDetailsTests
    {
        [Fact]
        [Trait("Feature", "Routes")]
        public void GetRouteTableWithDetailsWithNonExistantTableName()
        {
            using (NetworkTestClient networkTestClient = new NetworkTestClient())
            {
                networkTestClient.Routes.EnsureRouteTableDoesntExist("NonExistantRouteTableName");

                try
                {
                    networkTestClient.Routes.GetRouteTableWithDetails("NonExistantRouteTableName", "MockDetailLevel");
                    Assert.True(false, "GetRouteTableWithDetails should throw a CloudException when the route table name is empty.");
                }
                catch (Hyak.Common.CloudException e)
                {
                    Assert.Equal("ResourceNotFound", e.Error.Code);
                    Assert.Equal("The Route Table NonExistantRouteTableName does not exist.", e.Error.Message);
                    Assert.Equal("Not Found", e.Response.ReasonPhrase);
                    Assert.Equal(HttpStatusCode.NotFound, e.Response.StatusCode);
                }
            }
        }

        [Fact]
        [Trait("Feature", "Routes")]
        public void GetRouteTableWithDetailsWithUnrecognizedDetailLevel()
        {
            using (NetworkTestClient networkTestClient = new NetworkTestClient())
            {
                networkTestClient.Routes.EnsureRouteIsOnlyRouteInRouteTable("MockRouteTableName", "MockRouteName");

                GetRouteTableResponse getResponse = networkTestClient.Routes.GetRouteTableWithDetails("MockRouteTableName", "MockDetailLevel");
                Assert.NotNull(getResponse);

                RouteTable routeTable = getResponse.RouteTable;
                Assert.NotNull(routeTable);
                Assert.Equal("MockRouteTableName", routeTable.Name);
                Assert.Equal("MockLabel", routeTable.Label);
                Assert.Equal(NetworkTestConstants.WideVNetLocation, routeTable.Location);
                Assert.Equal(RouteTableState.Created, routeTable.RouteTableState);
                Assert.NotNull(routeTable.RouteList);
                Assert.Equal(0, routeTable.RouteList.Count);
            }
        }

        [Fact]
        [Trait("Feature", "Routes")]
        public void GetRouteTableWithDetailsWithRoutesDetailLevel()
        {
            using (NetworkTestClient networkTestClient = new NetworkTestClient())
            {
                networkTestClient.Routes.EnsureRouteIsOnlyRouteInRouteTable("MockRouteTableName", "MockRouteName");

                GetRouteTableResponse getResponse = networkTestClient.Routes.GetRouteTableWithDetails("MockRouteTableName", "Routes");
                Assert.NotNull(getResponse);

                RouteTable routeTable = getResponse.RouteTable;
                Assert.NotNull(routeTable);
                Assert.Equal("MockRouteTableName", routeTable.Name);
                Assert.Equal("MockLabel", routeTable.Label);
                Assert.Equal(NetworkTestConstants.WideVNetLocation, routeTable.Location);
                Assert.Equal(RouteTableState.Created, routeTable.RouteTableState);
                Assert.NotNull(routeTable.RouteList);
                Assert.NotEqual(0, routeTable.RouteList.Count);
            }
        }

        [Fact]
        [Trait("Feature", "Routes")]
        public void GetRouteTableWithDetailsWithFullDetailLevel()
        {
            using (NetworkTestClient networkTestClient = new NetworkTestClient())
            {
                networkTestClient.Routes.EnsureRouteIsOnlyRouteInRouteTable("MockRouteTableName", "MockRouteName");

                GetRouteTableResponse getResponse = networkTestClient.Routes.GetRouteTableWithDetails("MockRouteTableName", "Full");
                Assert.NotNull(getResponse);

                RouteTable routeTable = getResponse.RouteTable;
                Assert.NotNull(routeTable);
                Assert.Equal("MockRouteTableName", routeTable.Name);
                Assert.Equal("MockLabel", routeTable.Label);
                Assert.Equal(NetworkTestConstants.WideVNetLocation, routeTable.Location);
                Assert.Equal(RouteTableState.Created, routeTable.RouteTableState);
                Assert.NotNull(routeTable.RouteList);
                Assert.NotEqual(0, routeTable.RouteList.Count);
            }
        }
    }
}
