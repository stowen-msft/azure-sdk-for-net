// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AutoManage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Automanage configuration profile assignment properties.
    /// </summary>
    public partial class ConfigurationProfileAssignmentProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConfigurationProfileAssignmentProperties class.
        /// </summary>
        public ConfigurationProfileAssignmentProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConfigurationProfileAssignmentProperties class.
        /// </summary>
        /// <param name="configurationProfile">A value indicating configuration
        /// profile. Possible values include: 'Azure virtual machine best
        /// practices – Dev/Test', 'Azure virtual machine best practices –
        /// Production'</param>
        /// <param name="targetId">The target VM resource URI</param>
        /// <param name="accountId">The Automanage account ARM Resource
        /// URI</param>
        /// <param name="configurationProfilePreferenceId">The configuration
        /// profile custom preferences ARM resource URI</param>
        /// <param name="provisioningState">The state of onboarding, which only
        /// appears in the response. Possible values include: 'Succeeded',
        /// 'Failed', 'Created'</param>
        /// <param name="compliance">The configuration setting for the
        /// configuration profile.</param>
        public ConfigurationProfileAssignmentProperties(string configurationProfile = default(string), string targetId = default(string), string accountId = default(string), string configurationProfilePreferenceId = default(string), string provisioningState = default(string), ConfigurationProfileAssignmentCompliance compliance = default(ConfigurationProfileAssignmentCompliance))
        {
            ConfigurationProfile = configurationProfile;
            TargetId = targetId;
            AccountId = accountId;
            ConfigurationProfilePreferenceId = configurationProfilePreferenceId;
            ProvisioningState = provisioningState;
            Compliance = compliance;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating configuration profile. Possible
        /// values include: 'Azure virtual machine best practices – Dev/Test',
        /// 'Azure virtual machine best practices – Production'
        /// </summary>
        [JsonProperty(PropertyName = "configurationProfile")]
        public string ConfigurationProfile { get; set; }

        /// <summary>
        /// Gets or sets the target VM resource URI
        /// </summary>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or sets the Automanage account ARM Resource URI
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the configuration profile custom preferences ARM
        /// resource URI
        /// </summary>
        [JsonProperty(PropertyName = "configurationProfilePreferenceId")]
        public string ConfigurationProfilePreferenceId { get; set; }

        /// <summary>
        /// Gets the state of onboarding, which only appears in the response.
        /// Possible values include: 'Succeeded', 'Failed', 'Created'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the configuration setting for the configuration
        /// profile.
        /// </summary>
        [JsonProperty(PropertyName = "compliance")]
        public ConfigurationProfileAssignmentCompliance Compliance { get; set; }

    }
}
