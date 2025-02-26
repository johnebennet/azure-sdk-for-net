// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> This enumerates the possible sources of a volume creation. </summary>
    public enum ElasticSanVolumeCreateOption
    {
        /// <summary> None. </summary>
        None,
        /// <summary> FromVolume. </summary>
        FromElasticSanVolume,
        /// <summary> FromDiskSnapshot. </summary>
        FromDiskSnapshot,
        /// <summary> Export. </summary>
        Export
    }
}
