// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Api error.
    /// </summary>
    public partial class ApiError
    {
        /// <summary>
        /// Initializes a new instance of the ApiError class.
        /// </summary>
        public ApiError() { }

        /// <summary>
        /// Initializes a new instance of the ApiError class.
        /// </summary>
        public ApiError(IList<ApiErrorBase> details = default(IList<ApiErrorBase>), InnerError innererror = default(InnerError), string code = default(string), string target = default(string), string message = default(string))
        {
            Details = details;
            Innererror = innererror;
            Code = code;
            Target = target;
            Message = message;
        }

        /// <summary>
        /// the Api error details
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ApiErrorBase> Details { get; set; }

        /// <summary>
        /// the Api inner error
        /// </summary>
        [JsonProperty(PropertyName = "innererror")]
        public InnerError Innererror { get; set; }

        /// <summary>
        /// the error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// the target of the particular error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
