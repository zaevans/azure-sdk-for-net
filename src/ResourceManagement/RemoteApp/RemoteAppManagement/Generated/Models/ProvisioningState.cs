// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningState
    {
        [EnumMember(Value = "Cancelled")]
        Cancelled,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Deprovisioning")]
        Deprovisioning,
        [EnumMember(Value = "Disabling")]
        Disabling,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Enabling")]
        Enabling,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Provisioning")]
        Provisioning,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Upgrading")]
        Upgrading
    }
}
