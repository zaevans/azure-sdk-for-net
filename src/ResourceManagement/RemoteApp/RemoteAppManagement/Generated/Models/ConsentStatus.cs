// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ConsentStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConsentStatus
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "NotFound")]
        NotFound,
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "Rejected")]
        Rejected,
        [EnumMember(Value = "Ignored")]
        Ignored
    }
}