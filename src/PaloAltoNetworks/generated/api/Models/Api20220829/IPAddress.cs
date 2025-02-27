// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Extensions;

    /// <summary>IP Address</summary>
    public partial class IPAddress :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddress,
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddressInternal
    {

        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private string _address;

        /// <summary>Address value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string Address { get => this._address; set => this._address = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Creates an new <see cref="IPAddress" /> instance.</summary>
        public IPAddress()
        {

        }
    }
    /// IP Address
    public partial interface IIPAddress :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.IJsonSerializable
    {
        /// <summary>Address value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Address value",
        SerializedName = @"address",
        PossibleTypes = new [] { typeof(string) })]
        string Address { get; set; }
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Id",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }

    }
    /// IP Address
    internal partial interface IIPAddressInternal

    {
        /// <summary>Address value</summary>
        string Address { get; set; }
        /// <summary>Resource Id</summary>
        string ResourceId { get; set; }

    }
}