// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> List of properties of a link provider. </summary>
    public partial class VpnLinkProviderProperties
    {
        /// <summary> Initializes a new instance of VpnLinkProviderProperties. </summary>
        public VpnLinkProviderProperties()
        {
        }

        /// <summary> Initializes a new instance of VpnLinkProviderProperties. </summary>
        /// <param name="linkProviderName"> Name of the link provider. </param>
        /// <param name="linkSpeedInMbps"> Link speed. </param>
        internal VpnLinkProviderProperties(string linkProviderName, int? linkSpeedInMbps)
        {
            LinkProviderName = linkProviderName;
            LinkSpeedInMbps = linkSpeedInMbps;
        }

        /// <summary> Name of the link provider. </summary>
        public string LinkProviderName { get; set; }
        /// <summary> Link speed. </summary>
        public int? LinkSpeedInMbps { get; set; }
    }
}
