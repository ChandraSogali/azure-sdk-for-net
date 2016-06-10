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
    /// Tokenizes urls and emails as one token.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.UaxEmailUrlTokenizer")]
    public partial class UaxEmailUrlTokenizer : Tokenizer
    {
        /// <summary>
        /// Initializes a new instance of the UaxEmailUrlTokenizer class.
        /// </summary>
        public UaxEmailUrlTokenizer() { }

        /// <summary>
        /// Initializes a new instance of the UaxEmailUrlTokenizer class.
        /// </summary>
        public UaxEmailUrlTokenizer(string name, int? maxTokenLength = default(int?))
            : base(name)
        {
            MaxTokenLength = maxTokenLength;
        }

        /// <summary>
        /// Gets or sets the maximum token length. Tokens longer than the
        /// maximum length are split. Default is 255.
        /// </summary>
        [JsonProperty(PropertyName = "maxTokenLength")]
        public int? MaxTokenLength { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
