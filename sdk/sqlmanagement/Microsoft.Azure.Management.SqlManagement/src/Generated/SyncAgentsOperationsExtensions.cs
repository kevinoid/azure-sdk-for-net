// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SyncAgentsOperations.
    /// </summary>
    public static partial class SyncAgentsOperationsExtensions
    {
            /// <summary>
            /// Gets a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            public static SyncAgent Get(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName)
            {
                return operations.GetAsync(resourceGroupName, serverName, syncAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SyncAgent> GetAsync(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, syncAgentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            /// <param name='parameters'>
            /// The requested sync agent resource state.
            /// </param>
            public static SyncAgent CreateOrUpdate(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName, SyncAgent parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, syncAgentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            /// <param name='parameters'>
            /// The requested sync agent resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SyncAgent> CreateOrUpdateAsync(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName, SyncAgent parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, syncAgentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            public static void Delete(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, syncAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, syncAgentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists sync agents in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            public static IPage<SyncAgent> ListByServer(this ISyncAgentsOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists sync agents in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SyncAgent>> ListByServerAsync(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates a sync agent key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            public static SyncAgentKeyProperties GenerateKey(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName)
            {
                return operations.GenerateKeyAsync(resourceGroupName, serverName, syncAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates a sync agent key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SyncAgentKeyProperties> GenerateKeyAsync(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateKeyWithHttpMessagesAsync(resourceGroupName, serverName, syncAgentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists databases linked to a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            public static IPage<SyncAgentLinkedDatabase> ListLinkedDatabases(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName)
            {
                return operations.ListLinkedDatabasesAsync(resourceGroupName, serverName, syncAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists databases linked to a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SyncAgentLinkedDatabase>> ListLinkedDatabasesAsync(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListLinkedDatabasesWithHttpMessagesAsync(resourceGroupName, serverName, syncAgentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            /// <param name='parameters'>
            /// The requested sync agent resource state.
            /// </param>
            public static SyncAgent BeginCreateOrUpdate(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName, SyncAgent parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, syncAgentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            /// <param name='parameters'>
            /// The requested sync agent resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SyncAgent> BeginCreateOrUpdateAsync(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName, SyncAgent parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, syncAgentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            public static void BeginDelete(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, syncAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server on which the sync agent is hosted.
            /// </param>
            /// <param name='syncAgentName'>
            /// The name of the sync agent.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISyncAgentsOperations operations, string resourceGroupName, string serverName, string syncAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, syncAgentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists sync agents in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SyncAgent> ListByServerNext(this ISyncAgentsOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists sync agents in a server.
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
            public static async Task<IPage<SyncAgent>> ListByServerNextAsync(this ISyncAgentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists databases linked to a sync agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SyncAgentLinkedDatabase> ListLinkedDatabasesNext(this ISyncAgentsOperations operations, string nextPageLink)
            {
                return operations.ListLinkedDatabasesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists databases linked to a sync agent.
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
            public static async Task<IPage<SyncAgentLinkedDatabase>> ListLinkedDatabasesNextAsync(this ISyncAgentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListLinkedDatabasesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
