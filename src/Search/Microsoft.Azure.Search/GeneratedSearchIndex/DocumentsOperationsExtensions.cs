// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for DocumentsOperations.
    /// </summary>
    public static partial class DocumentsOperationsExtensions
    {
            /// <summary>
            /// Queries the number of documents in the Azure Search index.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static long Count(this IDocumentsOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return Task.Factory.StartNew(s => ((IDocumentsOperations)s).CountAsync(searchRequestOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Queries the number of documents in the Azure Search index.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<long> CountAsync(this IDocumentsOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CountWithHttpMessagesAsync(searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
