// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Routing rules in production experiments.
    /// </summary>
    public partial class Experiments
    {
        /// <summary>
        /// Initializes a new instance of the Experiments class.
        /// </summary>
        public Experiments()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Experiments class.
        /// </summary>
        /// <param name="rampUpRules">List of ramp-up rules.</param>
        public Experiments(IList<RampUpRule> rampUpRules = default(IList<RampUpRule>))
        {
            RampUpRules = rampUpRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of ramp-up rules.
        /// </summary>
        [JsonProperty(PropertyName = "rampUpRules")]
        public IList<RampUpRule> RampUpRules { get; set; }

    }
}
