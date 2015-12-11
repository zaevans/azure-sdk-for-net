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
    /// A wrapper for virtual machine command details to be used as a parameter
    /// </summary>
    public partial class VmCommandDetailsWrapper : Resource
    {
        /// <summary>
        /// The etag of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// The URL for requesting next page of resources.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Message to display to the user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logoffMessage")]
        public string LogoffMessage { get; set; }

        /// <summary>
        /// Time to wait before restarting the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logoffWaitTimeInSeconds")]
        public int? LogoffWaitTimeInSeconds { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
