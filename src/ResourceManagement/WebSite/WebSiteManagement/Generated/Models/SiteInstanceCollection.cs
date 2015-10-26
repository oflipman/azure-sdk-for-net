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
    /// Collection of site instances
    /// </summary>
    public partial class SiteInstanceCollection
    {
        /// <summary>
        /// Initializes a new instance of the SiteInstanceCollection class.
        /// </summary>
        public SiteInstanceCollection() { }

        /// <summary>
        /// Initializes a new instance of the SiteInstanceCollection class.
        /// </summary>
        public SiteInstanceCollection(IList<SiteInstance> value = default(IList<SiteInstance>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SiteInstance> Value { get; set; }

        /// <summary>
        /// Link to next page of resources
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
