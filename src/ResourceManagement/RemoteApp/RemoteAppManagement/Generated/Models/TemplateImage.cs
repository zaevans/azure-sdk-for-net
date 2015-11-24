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
    /// The wrapper for the template image object
    /// </summary>
    public partial class TemplateImage : Resource
    {
        /// <summary>
        /// The etag of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// The friendly name for the image
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string TemplateImageName { get; set; }

        /// <summary>
        /// The image size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "properties.size")]
        public long? Size { get; set; }

        /// <summary>
        /// The status of the template image. Possible values for this
        /// property include: 'UploadPending', 'UploadInProgress',
        /// 'UploadComplete', 'UploadFailed', 'ImportInProgress',
        /// 'ImportFailed', 'ImportComplete', 'ValidationFailed', 'Ready',
        /// 'Corrupted', 'Deleting'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public TemplateImageStatus? Status { get; set; }

        /// <summary>
        /// The list of regions where the image can be used
        /// </summary>
        [JsonProperty(PropertyName = "properties.locationList")]
        public IList<string> LocationList { get; set; }

        /// <summary>
        /// The type of the template image. Possible values for this property
        /// include: 'CustomerImage', 'PlatformImage', 'Unknown'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.templateImageType")]
        public TemplateImageType? TemplateImageType { get; set; }

        /// <summary>
        /// A TrialOnly platform template image may be used only during a
        /// subscription's RemoteApp trial period. Once billing is activated,
        /// a collection using a TrialOnly template image will be permanently
        /// disabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trialOnly")]
        public bool? TrialOnly { get; set; }

        /// <summary>
        /// If the template image for this collection includes Office this
        /// will specify the type. Possible values for this property include:
        /// 'None', 'OfficeSAL', 'Office365', 'Unknown'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.officeType")]
        public OfficeType? OfficeType { get; set; }

        /// <summary>
        /// The number of collections linked to the template image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfLinkedCollections")]
        public double? NumberOfLinkedCollections { get; set; }

        /// <summary>
        /// The time when the template image upload was completed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uploadCompleteTime")]
        public DateTime? UploadCompleteTime { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
