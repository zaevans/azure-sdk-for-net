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
    /// The details for creating a collection.
    /// </summary>
    public partial class CollectionCreationDetails
    {
        /// <summary>
        /// The collection's name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A description for the collection
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The name of the template image for the collection
        /// </summary>
        [JsonProperty(PropertyName = "templateImageName")]
        public string TemplateImageName { get; set; }

        /// <summary>
        /// The name of the Vnet for the collection
        /// </summary>
        [JsonProperty(PropertyName = "vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// The ID of the Vnet for the collection
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkId")]
        public string VirtualNetworkId { get; set; }

        /// <summary>
        /// The account subscriptionId
        /// </summary>
        [JsonProperty(PropertyName = "adInfo")]
        public ActiveDirectoryConfig AdInfo { get; set; }

        /// <summary>
        /// The plan name associated with this collection.
        /// </summary>
        [JsonProperty(PropertyName = "billingPlanName")]
        public string BillingPlanName { get; set; }

        /// <summary>
        /// Optional customer-defined RDP properties of the collection.
        /// </summary>
        [JsonProperty(PropertyName = "customRdpProperty")]
        public string CustomRdpProperty { get; set; }

        /// <summary>
        /// A flag denoting if this collection is ready for publishing
        /// operations.
        /// </summary>
        [JsonProperty(PropertyName = "readyForPublishing")]
        public bool? ReadyForPublishing { get; set; }

        /// <summary>
        /// The collection mode. Possible values for this property include:
        /// 'Unassigned', 'Apps', 'Desktop'.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public CollectionMode? Mode { get; set; }

        /// <summary>
        /// The amount of time to wait, in minutes, before forcing logoff.
        /// </summary>
        [JsonProperty(PropertyName = "waitBeforeShutdownInMinutes")]
        public int? WaitBeforeShutdownInMinutes { get; set; }

        /// <summary>
        /// The home region for the account
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// A list of details of the published applications
        /// </summary>
        [JsonProperty(PropertyName = "publishedApplications")]
        public ApplicationDetailsList PublishedApplications { get; set; }

        /// <summary>
        /// A list of allowed security principals
        /// </summary>
        [JsonProperty(PropertyName = "allowedPrincipals")]
        public SecurityPrincipalList AllowedPrincipals { get; set; }

        /// <summary>
        /// List of the DNS Servers.
        /// </summary>
        [JsonProperty(PropertyName = "DnsServers")]
        public IList<string> DnsServers { get; set; }

        /// <summary>
        /// The subnet name of the customer created Azure VNet.
        /// </summary>
        [JsonProperty(PropertyName = "subnetName")]
        public string SubnetName { get; set; }

        /// <summary>
        /// True if the collection is domain joined, false otherwise
        /// </summary>
        [JsonProperty(PropertyName = "notDomainJoined")]
        public bool? NotDomainJoined { get; set; }

        /// <summary>
        /// The name of the resource group the collection is in
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// A GUID for the response
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

    }
}