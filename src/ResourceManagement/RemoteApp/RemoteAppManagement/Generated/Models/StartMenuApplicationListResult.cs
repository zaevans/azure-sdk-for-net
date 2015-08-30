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
    /// Definition containing details of Start Menu applications.
    /// </summary>
    public partial class StartMenuApplicationListResult
    {
        /// <summary>
        /// StartMenuApplication properties.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<StartMenuApplication> Value { get; set; }

    }
}
