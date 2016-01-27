// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Sku discovery information
    /// </summary>
    public partial class SkuInfo
    {
        /// <summary>
        /// Initializes a new instance of the SkuInfo class.
        /// </summary>
        public SkuInfo() { }

        /// <summary>
        /// Initializes a new instance of the SkuInfo class.
        /// </summary>
        public SkuInfo(string resourceType = default(string), SkuDescription sku = default(SkuDescription), SkuCapacity capacity = default(SkuCapacity))
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
        }

        /// <summary>
        /// Resource type that this sku applies to
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Name and tier of the sku
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SkuDescription Sku { get; set; }

        /// <summary>
        /// Min, max, and default scale values of the sku
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public SkuCapacity Capacity { get; set; }

    }
}
