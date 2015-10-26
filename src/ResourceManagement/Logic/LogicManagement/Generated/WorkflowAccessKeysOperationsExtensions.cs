// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class WorkflowAccessKeysOperationsExtensions
    {
            /// <summary>
            /// Gets a list of workflow access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            public static IPage<WorkflowAccessKey> List(this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, int? top = default(int?))
            {
                return Task.Factory.StartNew(s => ((IWorkflowAccessKeysOperations)s).ListAsync(resourceGroupName, workflowName, top), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkflowAccessKey>> ListAsync( this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<WorkflowAccessKey>> result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workflowName, top, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a workflow access key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            public static WorkflowAccessKey Get(this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName)
            {
                return Task.Factory.StartNew(s => ((IWorkflowAccessKeysOperations)s).GetAsync(resourceGroupName, workflowName, accessKeyName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a workflow access key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowAccessKey> GetAsync( this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<WorkflowAccessKey> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workflowName, accessKeyName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Creates or updates a workflow access key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            /// <param name='workflowAccesskey'>
            /// The workflow access key.
            /// </param>
            public static WorkflowAccessKey CreateOrUpdate(this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName, WorkflowAccessKey workflowAccesskey)
            {
                return Task.Factory.StartNew(s => ((IWorkflowAccessKeysOperations)s).CreateOrUpdateAsync(resourceGroupName, workflowName, accessKeyName, workflowAccesskey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a workflow access key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            /// <param name='workflowAccesskey'>
            /// The workflow access key.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowAccessKey> CreateOrUpdateAsync( this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName, WorkflowAccessKey workflowAccesskey, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<WorkflowAccessKey> result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workflowName, accessKeyName, workflowAccesskey, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes a workflow access key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            public static void Delete(this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName)
            {
                Task.Factory.StartNew(s => ((IWorkflowAccessKeysOperations)s).DeleteAsync(resourceGroupName, workflowName, accessKeyName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a workflow access key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workflowName, accessKeyName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Lists secret keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            public static WorkflowSecretKeys ListSecretKeys(this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName)
            {
                return Task.Factory.StartNew(s => ((IWorkflowAccessKeysOperations)s).ListSecretKeysAsync(resourceGroupName, workflowName, accessKeyName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists secret keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowSecretKeys> ListSecretKeysAsync( this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<WorkflowSecretKeys> result = await operations.ListSecretKeysWithHttpMessagesAsync(resourceGroupName, workflowName, accessKeyName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Regenerates secret key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters.
            /// </param>
            public static WorkflowSecretKeys RegenerateSecretKey(this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName, RegenerateSecretKeyParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IWorkflowAccessKeysOperations)s).RegenerateSecretKeyAsync(resourceGroupName, workflowName, accessKeyName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates secret key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='accessKeyName'>
            /// The workflow access key name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowSecretKeys> RegenerateSecretKeyAsync( this IWorkflowAccessKeysOperations operations, string resourceGroupName, string workflowName, string accessKeyName, RegenerateSecretKeyParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<WorkflowSecretKeys> result = await operations.RegenerateSecretKeyWithHttpMessagesAsync(resourceGroupName, workflowName, accessKeyName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of workflow access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkflowAccessKey> ListNext(this IWorkflowAccessKeysOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IWorkflowAccessKeysOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkflowAccessKey>> ListNextAsync( this IWorkflowAccessKeysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<WorkflowAccessKey>> result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
