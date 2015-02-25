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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RemoteApp.Models;

namespace Microsoft.Azure.Management.RemoteApp
{
    /// <summary>
    /// RemoteApp collection operations.
    /// </summary>
    public partial interface ICollectionOperations
    {
        /// <summary>
        /// Creates a collection with the given details.
        /// </summary>
        /// <param name='populateOnly'>
        /// A flag denoting if the request is to populate the creation details
        /// of the collection or update and deploy (true for populate only).
        /// </param>
        /// <param name='collectionDetails'>
        /// Details for the collection to be created.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> CreateAsync(bool populateOnly, CollectionCreationDetails collectionDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the given collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The name of the collection.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> DeleteAsync(string collectionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Disconnects the session associated with the user UPN
        /// </summary>
        /// <param name='collectionName'>
        /// The RemoteApp collection name where the session exists.
        /// </param>
        /// <param name='sessionParameter'>
        /// The session command parameter to disconnect a session.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> DisconnectSessionAsync(string collectionName, SessionCommandParameter sessionParameter, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns the result for a given collection
        /// </summary>
        /// <param name='collectionName'>
        /// The name of the collection.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response for the GetServiceList operation.
        /// </returns>
        Task<CollectionResult> GetAsync(string collectionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns the specified Active directory's configuration.
        /// </summary>
        /// <param name='collectionName'>
        /// Name of the collection
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Similar in structure to the VNet class but used to return one of
        /// these in GET requests.
        /// </returns>
        Task<ActiveDirectoryConfigResult> GetAdAsync(string collectionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the summary of collection usage for the requested period.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='year'>
        /// The billing year in YYYY format.
        /// </param>
        /// <param name='month'>
        /// The billing month in range of 01 through 12 inclusive.
        /// </param>
        /// <param name='locale'>
        /// The locale value which will be applied to the generated usage
        /// report.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The collection usage billing details.
        /// </returns>
        Task<CollectionUsageDetailsResult> GetUsageDetailsAsync(string collectionName, string year, string month, string locale, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the summary of collection usage for the requested period.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='year'>
        /// The billing year in YYYY format.
        /// </param>
        /// <param name='month'>
        /// The billing month in range of 01 through 12 inclusive.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The collection usage billing summary.
        /// </returns>
        Task<CollectionUsageSummaryListResult> GetUsageSummaryAsync(string collectionName, string year, string month, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns the list of all collection currently available for the
        /// subscription Id
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response for the get collections list operation.
        /// </returns>
        Task<CollectionListResult> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the list of all sessions in the collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The RemoteApp collection name where the sessions exists.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List of user sessions in a given collection.
        /// </returns>
        Task<CollectionSessionListResult> ListSessionsAsync(string collectionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Logs off the session associated with the user UPN
        /// </summary>
        /// <param name='collectionName'>
        /// The RemoteApp collection name where the session exists.
        /// </param>
        /// <param name='sessionParameter'>
        /// The session command parameter to logoff a session.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> LogoffSessionAsync(string collectionName, SessionCommandParameter sessionParameter, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a list of all regions where collection can be created for the
        /// subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list of locations.
        /// </returns>
        Task<RegionListResult> RegionListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Sends message to the session associated with the user UPN
        /// </summary>
        /// <param name='collectionName'>
        /// The RemoteApp collection name where the session exists.
        /// </param>
        /// <param name='sessionMessageParameter'>
        /// The session command parameter to send message to a session.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> SendMessageToSessionAsync(string collectionName, SessionSendMessageCommandParameter sessionMessageParameter, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets a new information to the collection with given id.
        /// </summary>
        /// <param name='collectionName'>
        /// The name of the collection.
        /// </param>
        /// <param name='forceRedeploy'>
        /// A flag denoting if the request is to re-deploy the collection after
        /// it is updated.
        /// </param>
        /// <param name='populateOnly'>
        /// A flag denoting if the request is to populate the collection
        /// details(true for populate only).
        /// </param>
        /// <param name='collectionDetails'>
        /// Details for the collection to be created.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> SetAsync(string collectionName, bool forceRedeploy, bool populateOnly, CollectionCreationDetails collectionDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the specified Active directory's configuration.
        /// </summary>
        /// <param name='collectionName'>
        /// Name of the collection
        /// </param>
        /// <param name='activeDirectoryConfigDetails'>
        /// AD config
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        Task<OperationResultWithTrackingId> SetAdAsync(string collectionName, ActiveDirectoryConfigParameter activeDirectoryConfigDetails, CancellationToken cancellationToken);
    }
}
