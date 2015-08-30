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

    /// <summary>
    /// Contains a security principal and that principal's consent status for
    /// this collection.
    /// </summary>
    public partial class SecurityPrincipalInfoProperties
    {
        /// <summary>
        /// The user consent status. Possible values for this property
        /// include: 'Unknown', 'NotFound', 'Pending', 'Accepted',
        /// 'Rejected', 'Ignored'.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ConsentStatus? Status { get; set; }

        /// <summary>
        /// The security principal information.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public SecurityPrincipal User { get; set; }

    }
}