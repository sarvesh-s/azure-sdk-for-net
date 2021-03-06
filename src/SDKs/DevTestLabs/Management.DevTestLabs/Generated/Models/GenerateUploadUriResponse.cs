// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Reponse body for generating an upload URI.
    /// </summary>
    public partial class GenerateUploadUriResponse
    {
        /// <summary>
        /// Initializes a new instance of the GenerateUploadUriResponse class.
        /// </summary>
        public GenerateUploadUriResponse() { }

        /// <summary>
        /// Initializes a new instance of the GenerateUploadUriResponse class.
        /// </summary>
        public GenerateUploadUriResponse(string uploadUri = default(string))
        {
            UploadUri = uploadUri;
        }

        /// <summary>
        /// The upload URI for the VHD.
        /// </summary>
        [JsonProperty(PropertyName = "uploadUri")]
        public string UploadUri { get; set; }

    }
}
