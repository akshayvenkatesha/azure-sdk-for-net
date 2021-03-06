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
using Microsoft.Azure;

namespace Microsoft.WindowsAzure.Management.RemoteApp
{
    /// <summary>
    /// RemoteApp user disk operations.
    /// </summary>
    public partial interface IUserDiskOperations
    {
        /// <summary>
        /// Copy user disk from one collection to the other and keep the source
        /// user disk.
        /// </summary>
        /// <param name='srcCollectionName'>
        /// The source collection name.
        /// </param>
        /// <param name='dstCollectionName'>
        /// The destination collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The user upn.
        /// </param>
        /// <param name='overwriteExistingUserDisk'>
        /// A flag denoting if the request is to overwrite the existing user
        /// disk
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CopyAsync(string srcCollectionName, string dstCollectionName, string userUpn, bool overwriteExistingUserDisk, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the given user disk.
        /// </summary>
        /// <param name='collectionName'>
        /// The RemoteApp collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The user upn.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string collectionName, string userUpn, CancellationToken cancellationToken);
    }
}
