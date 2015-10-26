// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class UsageOperationsExtensions
    {
            /// <summary>
            /// Returns usage records for specified subscription and resource groups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of resource group
            /// </param>
            /// <param name='environmentName'>
            /// Environment name
            /// </param>
            /// <param name='lastId'>
            /// Last marker that was returned from the batch
            /// </param>
            /// <param name='batchSize'>
            /// size of the batch to be returned.
            /// </param>
            public static object GetUsage(this IUsageOperations operations, string resourceGroupName, string environmentName, string lastId, int? batchSize)
            {
                return Task.Factory.StartNew(s => ((IUsageOperations)s).GetUsageAsync(resourceGroupName, environmentName, lastId, batchSize), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns usage records for specified subscription and resource groups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of resource group
            /// </param>
            /// <param name='environmentName'>
            /// Environment name
            /// </param>
            /// <param name='lastId'>
            /// Last marker that was returned from the batch
            /// </param>
            /// <param name='batchSize'>
            /// size of the batch to be returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetUsageAsync( this IUsageOperations operations, string resourceGroupName, string environmentName, string lastId, int? batchSize, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<object> result = await operations.GetUsageWithHttpMessagesAsync(resourceGroupName, environmentName, lastId, batchSize, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
