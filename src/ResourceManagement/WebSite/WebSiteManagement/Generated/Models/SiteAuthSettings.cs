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
    /// Configuration settings for the Azure App Service Authentication /
    /// Authorization feature.
    /// </summary>
    public partial class SiteAuthSettings
    {
        /// <summary>
        /// Initializes a new instance of the SiteAuthSettings class.
        /// </summary>
        public SiteAuthSettings() { }

        /// <summary>
        /// Initializes a new instance of the SiteAuthSettings class.
        /// </summary>
        public SiteAuthSettings(string clientId = default(string), string issuer = default(string), string aadClientId = default(string), string openIdIssuer = default(string))
        {
            ClientId = clientId;
            Issuer = issuer;
            AadClientId = aadClientId;
            OpenIdIssuer = openIdIssuer;
        }

        /// <summary>
        /// Gets or sets the unique ID of this relying party application,
        /// known as the client_id.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the OpenID Connect Issuer URI that represents the
        /// entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the
        /// URI of the directory tenant, e.g.
        /// https://sts.windows.net/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token
        /// issuer.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aadClientId")]
        public string AadClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "openIdIssuer")]
        public string OpenIdIssuer { get; set; }

    }
}
