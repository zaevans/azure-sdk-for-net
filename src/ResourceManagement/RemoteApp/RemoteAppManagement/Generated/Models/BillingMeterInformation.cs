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
    /// </summary>
    public partial class BillingMeterInformation
    {
        /// <summary>
        /// geo for the billing meter
        /// </summary>
        [JsonProperty(PropertyName = "geo")]
        public string Geo { get; set; }

        /// <summary>
        /// The MINT ID for the flat rate
        /// </summary>
        [JsonProperty(PropertyName = "flatMeterId")]
        public string FlatMeterId { get; set; }

        /// <summary>
        /// The MINT ID for the overage rate
        /// </summary>
        [JsonProperty(PropertyName = "overageMeterId")]
        public string OverageMeterId { get; set; }

    }
}
