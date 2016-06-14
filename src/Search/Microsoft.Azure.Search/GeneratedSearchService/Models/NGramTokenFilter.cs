// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Generates n-grams of the given size(s).
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.NGramTokenFilter")]
    public partial class NGramTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the NGramTokenFilter class.
        /// </summary>
        public NGramTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the NGramTokenFilter class.
        /// </summary>
        public NGramTokenFilter(string name, int? minGram = default(int?), int? maxGram = default(int?))
            : base(name)
        {
            MinGram = minGram;
            MaxGram = maxGram;
        }

        /// <summary>
        /// Gets or sets the minimum n-gram length. Default is 1.
        /// </summary>
        [JsonProperty(PropertyName = "minGram")]
        public int? MinGram { get; set; }

        /// <summary>
        /// Gets or sets the maximum n-gram length. Default is 2.
        /// </summary>
        [JsonProperty(PropertyName = "maxGram")]
        public int? MaxGram { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}