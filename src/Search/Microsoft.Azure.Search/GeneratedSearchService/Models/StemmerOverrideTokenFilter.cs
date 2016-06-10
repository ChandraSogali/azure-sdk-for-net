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
    /// Provides the ability to override other stemming filters with custom
    /// dictionary-based stemming. Any dictionary-stemmed terms will be
    /// marked as keywords so that they will not be stemmed with stemmers
    /// down the chain. Must be placed before any stemming filters.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.StemmerOverrideTokenFilter")]
    public partial class StemmerOverrideTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the StemmerOverrideTokenFilter class.
        /// </summary>
        public StemmerOverrideTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the StemmerOverrideTokenFilter class.
        /// </summary>
        public StemmerOverrideTokenFilter(string name, IList<string> rules)
            : base(name)
        {
            Rules = rules;
        }

        /// <summary>
        /// Gets or sets a list of stemming rules in the following format:
        /// "word =&gt; stem", for example: "ran =&gt; run"
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<string> Rules { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (Rules == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rules");
            }
        }
    }
}
