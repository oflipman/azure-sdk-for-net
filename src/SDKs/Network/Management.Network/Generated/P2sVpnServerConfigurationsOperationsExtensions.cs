// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for P2sVpnServerConfigurationsOperations.
    /// </summary>
    public static partial class P2sVpnServerConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Retrieves the details of a P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            public static P2SVpnServerConfiguration Get(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName)
            {
                return operations.GetAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of a P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<P2SVpnServerConfiguration> GetAsync(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a P2SVpnServerConfiguration to associate with a VirtualWan if it
            /// doesn't exist else updates the existing P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='p2SVpnServerConfigurationParameters'>
            /// Parameters supplied to create or Update a P2SVpnServerConfiguration.
            /// </param>
            public static P2SVpnServerConfiguration CreateOrUpdate(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName, P2SVpnServerConfiguration p2SVpnServerConfigurationParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName, p2SVpnServerConfigurationParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a P2SVpnServerConfiguration to associate with a VirtualWan if it
            /// doesn't exist else updates the existing P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='p2SVpnServerConfigurationParameters'>
            /// Parameters supplied to create or Update a P2SVpnServerConfiguration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<P2SVpnServerConfiguration> CreateOrUpdateAsync(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName, P2SVpnServerConfiguration p2SVpnServerConfigurationParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName, p2SVpnServerConfigurationParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            public static void Delete(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName)
            {
                operations.DeleteAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves all P2SVpnServerConfigurations for a particular VirtualWan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            public static IPage<P2SVpnServerConfiguration> ListByVirtualWan(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName)
            {
                return operations.ListByVirtualWanAsync(resourceGroupName, virtualWanName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves all P2SVpnServerConfigurations for a particular VirtualWan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<P2SVpnServerConfiguration>> ListByVirtualWanAsync(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVirtualWanWithHttpMessagesAsync(resourceGroupName, virtualWanName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a P2SVpnServerConfiguration to associate with a VirtualWan if it
            /// doesn't exist else updates the existing P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='p2SVpnServerConfigurationParameters'>
            /// Parameters supplied to create or Update a P2SVpnServerConfiguration.
            /// </param>
            public static P2SVpnServerConfiguration BeginCreateOrUpdate(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName, P2SVpnServerConfiguration p2SVpnServerConfigurationParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName, p2SVpnServerConfigurationParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a P2SVpnServerConfiguration to associate with a VirtualWan if it
            /// doesn't exist else updates the existing P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualWan.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='p2SVpnServerConfigurationParameters'>
            /// Parameters supplied to create or Update a P2SVpnServerConfiguration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<P2SVpnServerConfiguration> BeginCreateOrUpdateAsync(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName, P2SVpnServerConfiguration p2SVpnServerConfigurationParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName, p2SVpnServerConfigurationParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            public static void BeginDelete(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a P2SVpnServerConfiguration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='virtualWanName'>
            /// The name of the VirtualWan.
            /// </param>
            /// <param name='p2SVpnServerConfigurationName'>
            /// The name of the P2SVpnServerConfiguration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IP2sVpnServerConfigurationsOperations operations, string resourceGroupName, string virtualWanName, string p2SVpnServerConfigurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualWanName, p2SVpnServerConfigurationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves all P2SVpnServerConfigurations for a particular VirtualWan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<P2SVpnServerConfiguration> ListByVirtualWanNext(this IP2sVpnServerConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListByVirtualWanNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves all P2SVpnServerConfigurations for a particular VirtualWan.
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
            public static async Task<IPage<P2SVpnServerConfiguration>> ListByVirtualWanNextAsync(this IP2sVpnServerConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVirtualWanNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
