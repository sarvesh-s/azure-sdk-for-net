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
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Hyak.Common;
using Hyak.Common.Internals;
using Microsoft.Azure.Insights;
using Microsoft.Azure.Management.Insights;
using Microsoft.Azure.Management.Insights.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.Insights
{
    /// <summary>
    /// Operations for managing storage diagnostic settings.
    /// </summary>
    internal partial class StorageDiagnosticSettingsOperations : IServiceOperations<InsightsManagementClient>, IStorageDiagnosticSettingsOperations
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StorageDiagnosticSettingsOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal StorageDiagnosticSettingsOperations(InsightsManagementClient client)
        {
            this._client = client;
        }
        
        private InsightsManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.Insights.InsightsManagementClient.
        /// </summary>
        public InsightsManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Gets the diagnostic settings for the specified storage service.
        /// </summary>
        /// <param name='resourceUri'>
        /// Required. The resource identifier of the storage service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async Task<StorageDiagnosticSettingsGetResponse> GetAsync(string resourceUri, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceUri == null)
            {
                throw new ArgumentNullException("resourceUri");
            }

            // Only valid for storage resources
            if (!Util.IsStorageResourceProvider(resourceUri))
            {
                throw new ArgumentException("This is not a valid storage resource Id.", "resourceUri");
            }

            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceUri", resourceUri);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceUri);

            List<string> queryParameters = new List<string>();
            url = url + "/providers/microsoft.insights/diagnosticSettings/storage";
            queryParameters.Add("api-version=2015-07-01");
            
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
                httpRequest.Headers.Add("Accept", "application/json");
                
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
                    StorageDiagnosticSettingsGetResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new StorageDiagnosticSettingsGetResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken nameValue = responseDoc["name"];
                            if (nameValue != null && nameValue.Type != JTokenType.Null)
                            {
                                string nameInstance = ((string)nameValue);
                                result.Name = nameInstance;
                            }
                            
                            JToken locationValue = responseDoc["location"];
                            if (locationValue != null && locationValue.Type != JTokenType.Null)
                            {
                                string locationInstance = ((string)locationValue);
                                result.Location = locationInstance;
                            }
                            
                            JToken propertiesValue = responseDoc["properties"];
                            if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                            {
                                StorageDiagnosticSettings propertiesInstance = new StorageDiagnosticSettings();
                                result.Properties = propertiesInstance;
                                
                                JToken loggingValue = propertiesValue["logging"];
                                if (loggingValue != null && loggingValue.Type != JTokenType.Null)
                                {
                                    StorageLoggingDiagnosticSettings loggingInstance = new StorageLoggingDiagnosticSettings();
                                    propertiesInstance.LoggingDiagnosticSettings = loggingInstance;
                                    
                                    JToken deleteValue = loggingValue["delete"];
                                    if (deleteValue != null && deleteValue.Type != JTokenType.Null)
                                    {
                                        bool deleteInstance = ((bool)deleteValue);
                                        loggingInstance.Delete = deleteInstance;
                                    }
                                    
                                    JToken readValue = loggingValue["read"];
                                    if (readValue != null && readValue.Type != JTokenType.Null)
                                    {
                                        bool readInstance = ((bool)readValue);
                                        loggingInstance.Read = readInstance;
                                    }
                                    
                                    JToken writeValue = loggingValue["write"];
                                    if (writeValue != null && writeValue.Type != JTokenType.Null)
                                    {
                                        bool writeInstance = ((bool)writeValue);
                                        loggingInstance.Write = writeInstance;
                                    }
                                    
                                    JToken retentionValue = loggingValue["retention"];
                                    if (retentionValue != null && retentionValue.Type != JTokenType.Null)
                                    {
                                        TimeSpan retentionInstance = XmlConvert.ToTimeSpan(((string)retentionValue));
                                        loggingInstance.Retention = retentionInstance;
                                    }
                                }
                                
                                JToken metricsValue = propertiesValue["metrics"];
                                if (metricsValue != null && metricsValue.Type != JTokenType.Null)
                                {
                                    StorageMetricDiagnosticSettings metricsInstance = new StorageMetricDiagnosticSettings();
                                    propertiesInstance.MetricDiagnosticSettings = metricsInstance;
                                    
                                    JToken aggregationsArray = metricsValue["aggregations"];
                                    if (aggregationsArray != null && aggregationsArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken aggregationsValue in ((JArray)aggregationsArray))
                                        {
                                            StorageMetricAggregation storageMetricAggregationInstance = new StorageMetricAggregation();
                                            metricsInstance.MetricAggregations.Add(storageMetricAggregationInstance);
                                            
                                            JToken scheduledTransferPeriodValue = aggregationsValue["scheduledTransferPeriod"];
                                            if (scheduledTransferPeriodValue != null && scheduledTransferPeriodValue.Type != JTokenType.Null)
                                            {
                                                TimeSpan scheduledTransferPeriodInstance = XmlConvert.ToTimeSpan(((string)scheduledTransferPeriodValue));
                                                storageMetricAggregationInstance.ScheduledTransferPeriod = scheduledTransferPeriodInstance;
                                            }
                                            
                                            JToken retentionValue2 = aggregationsValue["retention"];
                                            if (retentionValue2 != null && retentionValue2.Type != JTokenType.Null)
                                            {
                                                TimeSpan retentionInstance2 = XmlConvert.ToTimeSpan(((string)retentionValue2));
                                                storageMetricAggregationInstance.Retention = retentionInstance2;
                                            }
                                            
                                            JToken levelValue = aggregationsValue["level"];
                                            if (levelValue != null && levelValue.Type != JTokenType.Null)
                                            {
                                                StorageMetricLevel levelInstance = ((StorageMetricLevel)Enum.Parse(typeof(StorageMetricLevel), ((string)levelValue), true));
                                                storageMetricAggregationInstance.Level = levelInstance;
                                            }
                                        }
                                    }
                                }
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
        
        /// <summary>
        /// Creates or update the diagnostic settings for the specified storage
        /// service.
        /// </summary>
        /// <param name='resourceUri'>
        /// Required. The resource identifier of the storage service.
        /// </param>
        /// <param name='parameters'>
        /// Required. The storage diagnostic settings parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Generic empty response. We only pass it to ensure json error
        /// handling
        /// </returns>
        public async Task<EmptyResponse> PutAsync(string resourceUri, StorageDiagnosticSettingsPutParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceUri == null)
            {
                throw new ArgumentNullException("resourceUri");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }

            // Only valid for storage resources
            if (!Util.IsStorageResourceProvider(resourceUri))
            {
                throw new ArgumentException("This is not a valid storage resource Id.", "resourceUri");
            }

            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceUri", resourceUri);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "PutAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceUri);

            List<string> queryParameters = new List<string>();
            url = url + "/providers/microsoft.insights/diagnosticSettings/storage";
            queryParameters.Add("api-version=2015-07-01");

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
                httpRequest.Method = HttpMethod.Put;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                JObject storageDiagnosticSettingsPutParametersValue = new JObject();
                requestDoc = storageDiagnosticSettingsPutParametersValue;
                
                if (parameters.Properties != null)
                {
                    JObject propertiesValue = new JObject();
                    storageDiagnosticSettingsPutParametersValue["properties"] = propertiesValue;
                    
                    if (parameters.Properties.LoggingDiagnosticSettings != null)
                    {
                        JObject loggingValue = new JObject();
                        propertiesValue["logging"] = loggingValue;
                        
                        loggingValue["delete"] = parameters.Properties.LoggingDiagnosticSettings.Delete;
                        
                        loggingValue["read"] = parameters.Properties.LoggingDiagnosticSettings.Read;
                        
                        loggingValue["write"] = parameters.Properties.LoggingDiagnosticSettings.Write;
                        
                        loggingValue["retention"] = XmlConvert.ToString(parameters.Properties.LoggingDiagnosticSettings.Retention);
                    }
                    
                    if (parameters.Properties.MetricDiagnosticSettings != null)
                    {
                        JObject metricsValue = new JObject();
                        propertiesValue["metrics"] = metricsValue;
                        
                        if (parameters.Properties.MetricDiagnosticSettings.MetricAggregations != null)
                        {
                            if (parameters.Properties.MetricDiagnosticSettings.MetricAggregations is ILazyCollection == false || ((ILazyCollection)parameters.Properties.MetricDiagnosticSettings.MetricAggregations).IsInitialized)
                            {
                                JArray aggregationsArray = new JArray();
                                foreach (StorageMetricAggregation aggregationsItem in parameters.Properties.MetricDiagnosticSettings.MetricAggregations)
                                {
                                    JObject storageMetricAggregationValue = new JObject();
                                    aggregationsArray.Add(storageMetricAggregationValue);
                                    
                                    storageMetricAggregationValue["scheduledTransferPeriod"] = XmlConvert.ToString(aggregationsItem.ScheduledTransferPeriod);
                                    
                                    storageMetricAggregationValue["retention"] = XmlConvert.ToString(aggregationsItem.Retention);
                                    
                                    storageMetricAggregationValue["level"] = aggregationsItem.Level.ToString();
                                }
                                metricsValue["aggregations"] = aggregationsArray;
                            }
                        }
                    }
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                
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
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Created && statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    EmptyResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Created || statusCode == HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new EmptyResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
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
