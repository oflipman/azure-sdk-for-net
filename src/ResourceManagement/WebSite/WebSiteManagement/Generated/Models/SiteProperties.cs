// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class SiteProperties
    {
        /// <summary>
        /// Initializes a new instance of the SiteProperties class.
        /// </summary>
        public SiteProperties() { }

        /// <summary>
        /// Initializes a new instance of the SiteProperties class.
        /// </summary>
        public SiteProperties(IList<NameValuePair> metadata = default(IList<NameValuePair>), IList<NameValuePair> properties = default(IList<NameValuePair>), IList<NameValuePair> appSettings = default(IList<NameValuePair>))
        {
            Metadata = metadata;
            Properties = properties;
            AppSettings = appSettings;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NameValuePair> Metadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<NameValuePair> Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appSettings")]
        public IList<NameValuePair> AppSettings { get; set; }

    }
}
