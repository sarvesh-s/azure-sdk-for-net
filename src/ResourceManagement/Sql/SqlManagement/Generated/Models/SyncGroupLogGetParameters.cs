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

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Parameters for get sync group logs.
    /// </summary>
    public partial class SyncGroupLogGetParameters
    {
        private string _continuationToken;
        
        /// <summary>
        /// Optional. The continuation token.
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }
        
        private string _endTime;
        
        /// <summary>
        /// Optional. Specifies the end time of the logs to query.
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _startTime;
        
        /// <summary>
        /// Required. Specifies the start time of the logs to query.
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _syncGroupName;
        
        /// <summary>
        /// Required. Specifies the sync group name.
        /// </summary>
        public string SyncGroupName
        {
            get { return this._syncGroupName; }
            set { this._syncGroupName = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. Specifies the type of the logs to query. The possible
        /// values: 'Error', 'Warning', 'Success' and 'All'.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SyncGroupLogGetParameters class.
        /// </summary>
        public SyncGroupLogGetParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the SyncGroupLogGetParameters class
        /// with required arguments.
        /// </summary>
        public SyncGroupLogGetParameters(string syncGroupName, string startTime, string type)
            : this()
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException("syncGroupName");
            }
            if (startTime == null)
            {
                throw new ArgumentNullException("startTime");
            }
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            this.SyncGroupName = syncGroupName;
            this.StartTime = startTime;
            this.Type = type;
        }
    }
}
