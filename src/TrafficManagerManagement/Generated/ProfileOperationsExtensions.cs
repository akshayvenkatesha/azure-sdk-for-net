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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.TrafficManager;
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Windows Azure Traffic Manager management API provides a RESTful set
    /// of web services that interact with Windows Azure Traffic Manager
    /// service for creating, updating, listing, and deleting Traffic Manager
    /// profiles and definitions.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166981.aspx for
    /// more information)
    /// </summary>
    public static partial class ProfileOperationsExtensions
    {
        /// <summary>
        /// The DNS name that you want to use. You must include
        /// .trafficmanager.net in the name.  (see
        /// http://msdn.microsoft.com/en-us/library/dn510368.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='dnsName'>
        /// Required. DNS name that you want to use
        /// </param>
        /// <returns>
        /// The response to the request for a listing of namespaces.
        /// </returns>
        public static DnsPrefixAvailabilityCheckResponse CheckDnsPrefixAvailability(this IProfileOperations operations, string dnsName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).CheckDnsPrefixAvailabilityAsync(dnsName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The DNS name that you want to use. You must include
        /// .trafficmanager.net in the name.  (see
        /// http://msdn.microsoft.com/en-us/library/dn510368.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='dnsName'>
        /// Required. DNS name that you want to use
        /// </param>
        /// <returns>
        /// The response to the request for a listing of namespaces.
        /// </returns>
        public static Task<DnsPrefixAvailabilityCheckResponse> CheckDnsPrefixAvailabilityAsync(this IProfileOperations operations, string dnsName)
        {
            return operations.CheckDnsPrefixAvailabilityAsync(dnsName, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a new profile for a domain name, owned by the specified
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758254.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='name'>
        /// Required. The name of the profile.
        /// </param>
        /// <param name='domainName'>
        /// Required. The name of the domain that the profile is being created
        /// for.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Create(this IProfileOperations operations, string name, string domainName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).CreateAsync(name, domainName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a new profile for a domain name, owned by the specified
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758254.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='name'>
        /// Required. The name of the profile.
        /// </param>
        /// <param name='domainName'>
        /// Required. The name of the domain that the profile is being created
        /// for.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> CreateAsync(this IProfileOperations operations, string name, string domainName)
        {
            return operations.CreateAsync(name, domainName, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a profile and all of its definitions. This operation cannot
        /// be reverted.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758256.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the profile.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IProfileOperations operations, string profileName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).DeleteAsync(profileName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a profile and all of its definitions. This operation cannot
        /// be reverted.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758256.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the profile.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IProfileOperations operations, string profileName)
        {
            return operations.DeleteAsync(profileName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns profile details, including all definition versions and
        /// their statuses.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758248.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the profile.
        /// </param>
        /// <returns>
        /// The Get Profile Details operation response.
        /// </returns>
        public static ProfileGetResponse Get(this IProfileOperations operations, string profileName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).GetAsync(profileName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns profile details, including all definition versions and
        /// their statuses.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758248.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the profile.
        /// </param>
        /// <returns>
        /// The Get Profile Details operation response.
        /// </returns>
        public static Task<ProfileGetResponse> GetAsync(this IProfileOperations operations, string profileName)
        {
            return operations.GetAsync(profileName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns all profiles owned by a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758249.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <returns>
        /// The List Profiles operation response.
        /// </returns>
        public static ProfilesListResponse List(this IProfileOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns all profiles owned by a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758249.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <returns>
        /// The List Profiles operation response.
        /// </returns>
        public static Task<ProfilesListResponse> ListAsync(this IProfileOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Enables or disables a profile.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758250.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the profile.
        /// </param>
        /// <param name='profileStatus'>
        /// Required. Specifies whether the profile should be enabled or
        /// disabled.
        /// </param>
        /// <param name='definitionVersionNumber'>
        /// Required. Version of the definition associated with the profile
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Update(this IProfileOperations operations, string profileName, ProfileDefinitionStatus profileStatus, int definitionVersionNumber)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).UpdateAsync(profileName, profileStatus, definitionVersionNumber);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Enables or disables a profile.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758250.aspx for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the profile.
        /// </param>
        /// <param name='profileStatus'>
        /// Required. Specifies whether the profile should be enabled or
        /// disabled.
        /// </param>
        /// <param name='definitionVersionNumber'>
        /// Required. Version of the definition associated with the profile
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> UpdateAsync(this IProfileOperations operations, string profileName, ProfileDefinitionStatus profileStatus, int definitionVersionNumber)
        {
            return operations.UpdateAsync(profileName, profileStatus, definitionVersionNumber, CancellationToken.None);
        }
    }
}
