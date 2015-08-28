// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Details of usage summary operation results.
    /// </summary>
    public partial class CollectionUsageSummary : Resource
    {
        /// <summary>
        /// The etag of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// The user's UPN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// The number of hours used which are included in the billing plan's
        /// base rate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.includedUsage")]
        public double? IncludedUsage { get; set; }

        /// <summary>
        /// The number of hours used beyond the billing plan's included usage,
        /// but not exceeding the billing plan's maximum cost.
        /// </summary>
        [JsonProperty(PropertyName = "properties.overageUsage")]
        public double? OverageUsage { get; set; }

        /// <summary>
        /// The number of hours used beyond the billing plan's maximum cost.
        /// These usage hours are not billed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.waivedUsage")]
        public double? WaivedUsage { get; set; }

        /// <summary>
        /// The total usage hours by the user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalUsage")]
        public double? TotalUsage { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}