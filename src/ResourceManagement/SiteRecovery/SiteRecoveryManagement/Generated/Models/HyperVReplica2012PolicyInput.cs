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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The HyperV enable protection input.
    /// </summary>
    public partial class HyperVReplica2012PolicyInput : PolicyProviderSpecificInput
    {
        private ushort _allowedAuthenticationType;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public ushort AllowedAuthenticationType
        {
            get { return this._allowedAuthenticationType; }
            set { this._allowedAuthenticationType = value; }
        }
        
        private int _applicationConsistentSnapshotFrequencyInHours;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int ApplicationConsistentSnapshotFrequencyInHours
        {
            get { return this._applicationConsistentSnapshotFrequencyInHours; }
            set { this._applicationConsistentSnapshotFrequencyInHours = value; }
        }
        
        private string _compression;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Compression
        {
            get { return this._compression; }
            set { this._compression = value; }
        }
        
        private string _initialReplicationMethod;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string InitialReplicationMethod
        {
            get { return this._initialReplicationMethod; }
            set { this._initialReplicationMethod = value; }
        }
        
        private string _offlineReplicationExportPath;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string OfflineReplicationExportPath
        {
            get { return this._offlineReplicationExportPath; }
            set { this._offlineReplicationExportPath = value; }
        }
        
        private string _offlineReplicationImportPath;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string OfflineReplicationImportPath
        {
            get { return this._offlineReplicationImportPath; }
            set { this._offlineReplicationImportPath = value; }
        }
        
        private System.TimeSpan? _onlineReplicationStartTime;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public System.TimeSpan? OnlineReplicationStartTime
        {
            get { return this._onlineReplicationStartTime; }
            set { this._onlineReplicationStartTime = value; }
        }
        
        private int _recoveryPoints;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int RecoveryPoints
        {
            get { return this._recoveryPoints; }
            set { this._recoveryPoints = value; }
        }
        
        private string _replicaDeletion;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ReplicaDeletion
        {
            get { return this._replicaDeletion; }
            set { this._replicaDeletion = value; }
        }
        
        private ushort _replicationPort;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public ushort ReplicationPort
        {
            get { return this._replicationPort; }
            set { this._replicationPort = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HyperVReplica2012PolicyInput
        /// class.
        /// </summary>
        public HyperVReplica2012PolicyInput()
        {
        }
    }
}
