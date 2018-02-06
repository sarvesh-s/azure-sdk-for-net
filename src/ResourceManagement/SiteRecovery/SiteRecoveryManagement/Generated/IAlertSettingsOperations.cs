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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of alert settings operations for the Site Recovery extension.
    /// </summary>
    public partial interface IAlertSettingsOperations
    {
        /// <summary>
        /// Updates the alert settings for the vault.
        /// </summary>
        /// <param name='alertSettingsName'>
        /// Alert Settings name.
        /// </param>
        /// <param name='input'>
        /// Configure Alerts Request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Model class for alerts response.
        /// </returns>
        Task<AlertSettingsResponse> ConfigureAsync(string alertSettingsName, ConfigureAlertSettingsRequest input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the alert settings for the vault.
        /// </summary>
        /// <param name='alertSettingsName'>
        /// Alert Settings name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Model class for alerts response.
        /// </returns>
        Task<AlertSettingsResponse> GetAsync(string alertSettingsName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of events under the vault.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Model class for list alerts response.
        /// </returns>
        Task<AlertSettingsListResponse> ListAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
