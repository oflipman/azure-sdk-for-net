
namespace Microsoft.Azure.Management.Scheduler.Models
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
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku(SkuDefinition? name = default(SkuDefinition?))
        {
            Name = name;
        }

        /// <summary>
        /// Gets or set the SKU. Possible values for this property include:
        /// 'Standard', 'Free', 'Premium'.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public SkuDefinition? Name { get; set; }

    }
}
