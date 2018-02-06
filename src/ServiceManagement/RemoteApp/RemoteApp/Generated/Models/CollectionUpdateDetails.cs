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
using Microsoft.WindowsAzure.Management.RemoteApp.Models;

namespace Microsoft.WindowsAzure.Management.RemoteApp.Models
{
    /// <summary>
    /// The parameters for collection set request.
    /// </summary>
    public partial class CollectionUpdateDetails
    {
        private CollectionAclLevel _aclLevel;
        
        /// <summary>
        /// Optional. Application ACL level (Collection or Application)
        /// </summary>
        public CollectionAclLevel AclLevel
        {
            get { return this._aclLevel; }
            set { this._aclLevel = value; }
        }
        
        private ActiveDirectoryConfig _adInfo;
        
        /// <summary>
        /// Optional. Active Directory configuration details to update.
        /// </summary>
        public ActiveDirectoryConfig AdInfo
        {
            get { return this._adInfo; }
            set { this._adInfo = value; }
        }
        
        private string _customRdpProperty;
        
        /// <summary>
        /// Optional. Customer defined Remote Desktop Protocol (RDP) properties
        /// of the collection.
        /// </summary>
        public string CustomRdpProperty
        {
            get { return this._customRdpProperty; }
            set { this._customRdpProperty = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. The description of the collection.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _planName;
        
        /// <summary>
        /// Optional. The new RemoteApp plan for the collection.
        /// </summary>
        public string PlanName
        {
            get { return this._planName; }
            set { this._planName = value; }
        }
        
        private string _subnetName;
        
        /// <summary>
        /// Optional. The name of the subnet to be used to patch the collection.
        /// </summary>
        public string SubnetName
        {
            get { return this._subnetName; }
            set { this._subnetName = value; }
        }
        
        private string _templateImageName;
        
        /// <summary>
        /// Optional. The name of the template image to be used to patch the
        /// collection.
        /// </summary>
        public string TemplateImageName
        {
            get { return this._templateImageName; }
            set { this._templateImageName = value; }
        }
        
        private int _waitBeforeShutdownInMinutes;
        
        /// <summary>
        /// Optional. Number of minutes to wait before logging off the end
        /// users when updating this collection.The value of -1 denotes
        /// immediate force logoff after the patching is successfully
        /// completed.The value of 0 denotes logoff after 60 minutes after the
        /// patching is successfully completed.Any other value less than 300
        /// minutes will be honored as is.
        /// </summary>
        public int WaitBeforeShutdownInMinutes
        {
            get { return this._waitBeforeShutdownInMinutes; }
            set { this._waitBeforeShutdownInMinutes = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CollectionUpdateDetails class.
        /// </summary>
        public CollectionUpdateDetails()
        {
        }
    }
}
