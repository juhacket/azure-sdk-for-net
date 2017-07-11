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
    /// A Disk.
    /// </summary>
    [JsonTransformation]
    public partial class Disk : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Disk class.
        /// </summary>
        public Disk() { }

        /// <summary>
        /// Initializes a new instance of the Disk class.
        /// </summary>
        public Disk(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string diskType = default(string), int? diskSizeGiB = default(int?), string leasedByLabVmId = default(string), string diskBlobName = default(string), string diskUri = default(string), DateTime? createdDate = default(DateTime?), string hostCaching = default(string), string managedDiskId = default(string), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(id, name, type, location, tags)
        {
            DiskType = diskType;
            DiskSizeGiB = diskSizeGiB;
            LeasedByLabVmId = leasedByLabVmId;
            DiskBlobName = diskBlobName;
            DiskUri = diskUri;
            CreatedDate = createdDate;
            HostCaching = hostCaching;
            ManagedDiskId = managedDiskId;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary>
        /// The storage type for the disk (i.e. Standard, Premium). Possible
        /// values include: 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskType")]
        public string DiskType { get; set; }

        /// <summary>
        /// The size of the disk in GibiBytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeGiB")]
        public int? DiskSizeGiB { get; set; }

        /// <summary>
        /// The resource ID of the VM to which this disk is leased.
        /// </summary>
        [JsonProperty(PropertyName = "properties.leasedByLabVmId")]
        public string LeasedByLabVmId { get; set; }

        /// <summary>
        /// When backed by a blob, the name of the VHD blob without extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskBlobName")]
        public string DiskBlobName { get; set; }

        /// <summary>
        /// When backed by a blob, the URI of underlying blob.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskUri")]
        public string DiskUri { get; set; }

        /// <summary>
        /// The creation date of the disk.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// The host caching policy of the disk (i.e. None, ReadOnly,
        /// ReadWrite).
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostCaching")]
        public string HostCaching { get; set; }

        /// <summary>
        /// When backed by managed disk, this is the ID of the compute disk
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedDiskId")]
        public string ManagedDiskId { get; set; }

        /// <summary>
        /// The provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// The unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

    }
}