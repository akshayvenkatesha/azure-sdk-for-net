// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// An Azure resource.
    /// </summary>
    [JsonTransformation]
    public partial class LabVirtualMachine : IResource
    {
        /// <summary>
        /// Initializes a new instance of the LabVirtualMachine class.
        /// </summary>
        public LabVirtualMachine() { }

        /// <summary>
        /// Initializes a new instance of the LabVirtualMachine class.
        /// </summary>
        public LabVirtualMachine(string notes = default(string), string ownerObjectId = default(string), string computeId = default(string), string customImageId = default(string), string osType = default(string), string size = default(string), string userName = default(string), string password = default(string), string sshKey = default(string), bool? isAuthenticationWithSshKey = default(bool?), string fqdn = default(string), string labSubnetName = default(string), string labVirtualNetworkId = default(string), bool? disallowPublicIpAddress = default(bool?), string builtInPassword = default(string), IList<ArtifactInstallProperties> artifacts = default(IList<ArtifactInstallProperties>), ArtifactDeploymentStatusProperties artifactDeploymentStatus = default(ArtifactDeploymentStatusProperties), GalleryImageReference galleryImageReference = default(GalleryImageReference), string provisioningState = default(string), string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Notes = notes;
            OwnerObjectId = ownerObjectId;
            ComputeId = computeId;
            CustomImageId = customImageId;
            OsType = osType;
            Size = size;
            UserName = userName;
            Password = password;
            SshKey = sshKey;
            IsAuthenticationWithSshKey = isAuthenticationWithSshKey;
            Fqdn = fqdn;
            LabSubnetName = labSubnetName;
            LabVirtualNetworkId = labVirtualNetworkId;
            DisallowPublicIpAddress = disallowPublicIpAddress;
            BuiltInPassword = builtInPassword;
            Artifacts = artifacts;
            ArtifactDeploymentStatus = artifactDeploymentStatus;
            GalleryImageReference = galleryImageReference;
            ProvisioningState = provisioningState;
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
        }

        /// <summary>
        /// The notes of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notes")]
        public string Notes { get; set; }

        /// <summary>
        /// The object identifier of the owner of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ownerObjectId")]
        public string OwnerObjectId { get; set; }

        /// <summary>
        /// The resource identifier (Microsof.Compute) of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.computeId")]
        public string ComputeId { get; set; }

        /// <summary>
        /// The custom image identifier of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customImageId")]
        public string CustomImageId { get; set; }

        /// <summary>
        /// The OS type of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public string OsType { get; set; }

        /// <summary>
        /// The size of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.size")]
        public string Size { get; set; }

        /// <summary>
        /// The user name of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// The password of the virtual machine administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// The SSH key of the virtual machine administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sshKey")]
        public string SshKey { get; set; }

        /// <summary>
        /// A value indicating whether this virtual machine uses an SSH key
        /// for authentication.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isAuthenticationWithSshKey")]
        public bool? IsAuthenticationWithSshKey { get; set; }

        /// <summary>
        /// The fully-qualified domain name of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// The lab subnet name of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labSubnetName")]
        public string LabSubnetName { get; set; }

        /// <summary>
        /// The lab virtual network identifier of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labVirtualNetworkId")]
        public string LabVirtualNetworkId { get; set; }

        /// <summary>
        /// Indicates whether the virtual machine is to be created without a
        /// public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disallowPublicIpAddress")]
        public bool? DisallowPublicIpAddress { get; set; }

        /// <summary>
        /// The built-in admin password of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.builtInPassword")]
        public string BuiltInPassword { get; set; }

        /// <summary>
        /// The artifacts to be installed on the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.artifacts")]
        public IList<ArtifactInstallProperties> Artifacts { get; set; }

        /// <summary>
        /// The artifact deployment status for the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.artifactDeploymentStatus")]
        public ArtifactDeploymentStatusProperties ArtifactDeploymentStatus { get; set; }

        /// <summary>
        /// The Microsoft Azure Marketplace image reference of the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.galleryImageReference")]
        public GalleryImageReference GalleryImageReference { get; set; }

        /// <summary>
        /// The provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// The identifier of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// The tags of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}