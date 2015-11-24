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
    /// Details needed to upload a template image
    /// </summary>
    public partial class TemplateImageCreateDetails
    {
        /// <summary>
        /// SAS URI for an OS disk in the VM library
        /// </summary>
        [JsonProperty(PropertyName = "sourceImageSasUri")]
        public string SourceImageSasUri { get; set; }

    }
}
