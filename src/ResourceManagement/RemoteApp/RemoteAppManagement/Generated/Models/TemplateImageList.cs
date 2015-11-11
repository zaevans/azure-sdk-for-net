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
    /// The response for the get template images operation.
    /// </summary>
    public partial class TemplateImageList
    {
        /// <summary>
        /// A list of template images
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<TemplateImage> Value { get; set; }

    }
}
