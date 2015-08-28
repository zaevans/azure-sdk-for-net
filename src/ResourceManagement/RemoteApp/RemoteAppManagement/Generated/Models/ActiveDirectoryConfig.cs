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
    /// Details of a RemoteApp active directory configuration.
    /// </summary>
    public partial class ActiveDirectoryConfig
    {
        /// <summary>
        /// The name of the on-premise domain to join the RD Session Host
        /// servers to.
        /// </summary>
        [JsonProperty(PropertyName = "DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// The name of your domain's organizational unit to assign the RD
        /// Session Host servers to, e.g.
        /// OU=MyOu,DC=MyDomain,DC=ParentDomain,DC=com. Attributes such as
        /// OU, DC, etc. must be in uppercase.
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationalUnit")]
        public string OrganizationalUnit { get; set; }

        /// <summary>
        /// The user name of a service account that has permission to add
        /// computers to the domain. The username must be specified in the
        /// UPN or down-level logon name format (user@some.domain or
        /// some.domain\\\\user).
        /// </summary>
        [JsonProperty(PropertyName = "ServiceAccountUserName")]
        public string ServiceAccountUserName { get; set; }

        /// <summary>
        /// The service account's password.
        /// </summary>
        [JsonProperty(PropertyName = "ServiceAccountPassword")]
        public string ServiceAccountPassword { get; set; }

    }
}