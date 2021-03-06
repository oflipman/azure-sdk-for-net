// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// May be used to filter budgets by resource group, resource, or meter.
    /// </summary>
    public partial class Filters
    {
        /// <summary>
        /// Initializes a new instance of the Filters class.
        /// </summary>
        public Filters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Filters class.
        /// </summary>
        /// <param name="resourceGroups">The list of filters on resource
        /// groups, allowed at subscription level only.</param>
        /// <param name="resources">The list of filters on resources.</param>
        /// <param name="meters">The list of filters on meters, mandatory for
        /// budgets of usage category. </param>
        public Filters(IList<string> resourceGroups = default(IList<string>), IList<string> resources = default(IList<string>), IList<string> meters = default(IList<string>))
        {
            ResourceGroups = resourceGroups;
            Resources = resources;
            Meters = meters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of filters on resource groups, allowed at
        /// subscription level only.
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroups")]
        public IList<string> ResourceGroups { get; set; }

        /// <summary>
        /// Gets or sets the list of filters on resources.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }

        /// <summary>
        /// Gets or sets the list of filters on meters, mandatory for budgets
        /// of usage category.
        /// </summary>
        [JsonProperty(PropertyName = "meters")]
        public IList<string> Meters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceGroups != null)
            {
                if (ResourceGroups.Count > 10)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "ResourceGroups", 10);
                }
                if (ResourceGroups.Count < 0)
                {
                    throw new ValidationException(ValidationRules.MinItems, "ResourceGroups", 0);
                }
            }
            if (Resources != null)
            {
                if (Resources.Count > 10)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "Resources", 10);
                }
                if (Resources.Count < 0)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Resources", 0);
                }
            }
            if (Meters != null)
            {
                if (Meters.Count > 10)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "Meters", 10);
                }
                if (Meters.Count < 0)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Meters", 0);
                }
            }
        }
    }
}
