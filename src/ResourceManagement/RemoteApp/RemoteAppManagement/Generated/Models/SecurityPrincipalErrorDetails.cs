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
    /// The security principal which failed this operation and the error.
    /// </summary>
    public partial class SecurityPrincipalErrorDetails
    {
        /// <summary>
        /// The security principal name.
        /// </summary>
        [JsonProperty(PropertyName = "securityPrincipal")]
        public string SecurityPrincipal { get; set; }

        /// <summary>
        /// The security principal operation result error code, if any.
        /// Possible values for this property include: 'CouldNotBeResolved',
        /// 'NotFound', 'AlreadyExists', 'NotSupported', 'NotDirsynced',
        /// 'AssignedToAnotherCollection'.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public SecurityPrincipalOperationError? Error { get; set; }

        /// <summary>
        /// Additional details about the error code, if available.
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public string ErrorDetails { get; set; }

    }
}
