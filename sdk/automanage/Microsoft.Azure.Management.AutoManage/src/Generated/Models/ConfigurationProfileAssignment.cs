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
    /// Configuration profile assignment is an association between a VM and
    /// automanage profile configuration.
    /// </summary>
    public partial class ConfigurationProfileAssignment : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationProfileAssignment
        /// class.
        /// </summary>
        public ConfigurationProfileAssignment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurationProfileAssignment
        /// class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="properties">Properties of the configuration profile
        /// assignment.</param>
        public ConfigurationProfileAssignment(string id = default(string), string name = default(string), string type = default(string), ConfigurationProfileAssignmentProperties properties = default(ConfigurationProfileAssignmentProperties))
            : base(id, name, type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of the configuration profile assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ConfigurationProfileAssignmentProperties Properties { get; set; }

    }
}
