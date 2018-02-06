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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.ApiManagement;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// Operation to return the status of the most recent synchronization
    /// between configuration database and the Git repository.
    /// </summary>
    internal partial class TenantConfigurationSyncStateOperation : IServiceOperations<ApiManagementClient>, ITenantConfigurationSyncStateOperation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TenantConfigurationSyncStateOperation class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal TenantConfigurationSyncStateOperation(ApiManagementClient client)
        {
            this._client = client;
        }
        
        private ApiManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.ApiManagement.ApiManagementClient.
        /// </summary>
        public ApiManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Gets Tenant Configuration Synchronization State operation result.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Get Tenant Configuration Synchronization State response details.
        /// </returns>
        public async Task<TenantConfigurationSyncStateResponse> GetAsync(string resourceGroupName, string serviceName, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serviceName == null)
            {
                throw new ArgumentNullException("serviceName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serviceName", serviceName);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.ApiManagement";
            url = url + "/service/";
            url = url + Uri.EscapeDataString(serviceName);
            url = url + "/tenant/configuration/syncState";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2016-10-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    TenantConfigurationSyncStateResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new TenantConfigurationSyncStateResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            TenantConfigurationSyncStateContract valueInstance = new TenantConfigurationSyncStateContract();
                            result.Value = valueInstance;
                            
                            JToken branchValue = responseDoc["branch"];
                            if (branchValue != null && branchValue.Type != JTokenType.Null)
                            {
                                string branchInstance = ((string)branchValue);
                                valueInstance.Branch = branchInstance;
                            }
                            
                            JToken commitIdValue = responseDoc["commitId"];
                            if (commitIdValue != null && commitIdValue.Type != JTokenType.Null)
                            {
                                string commitIdInstance = ((string)commitIdValue);
                                valueInstance.CommitId = commitIdInstance;
                            }
                            
                            JToken isExportValue = responseDoc["isExport"];
                            if (isExportValue != null && isExportValue.Type != JTokenType.Null)
                            {
                                bool isExportInstance = ((bool)isExportValue);
                                valueInstance.IsExport = isExportInstance;
                            }
                            
                            JToken isSyncedValue = responseDoc["isSynced"];
                            if (isSyncedValue != null && isSyncedValue.Type != JTokenType.Null)
                            {
                                bool isSyncedInstance = ((bool)isSyncedValue);
                                valueInstance.IsSynced = isSyncedInstance;
                            }
                            
                            JToken isGitEnabledValue = responseDoc["isGitEnabled"];
                            if (isGitEnabledValue != null && isGitEnabledValue.Type != JTokenType.Null)
                            {
                                bool isGitEnabledInstance = ((bool)isGitEnabledValue);
                                valueInstance.IsGitEnabled = isGitEnabledInstance;
                            }
                            
                            JToken syncDateValue = responseDoc["syncDate"];
                            if (syncDateValue != null && syncDateValue.Type != JTokenType.Null)
                            {
                                DateTime syncDateInstance = ((DateTime)syncDateValue);
                                valueInstance.SyncDate = syncDateInstance;
                            }
                            
                            JToken configurationChangeDateValue = responseDoc["configurationChangeDate"];
                            if (configurationChangeDateValue != null && configurationChangeDateValue.Type != JTokenType.Null)
                            {
                                DateTime configurationChangeDateInstance = ((DateTime)configurationChangeDateValue);
                                valueInstance.ConfigurationChangeDate = configurationChangeDateInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
