// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrefixesOperations.
    /// </summary>
    public static partial class PrefixesOperationsExtensions
    {
            /// <summary>
            /// Lists the peerings prefix in the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='peeringServiceName'>
            /// The peering service name.
            /// </param>
            public static IPage<PeeringServicePrefix> ListByPeeringService(this IPrefixesOperations operations, string resourceGroupName, string peeringServiceName)
            {
                return operations.ListByPeeringServiceAsync(resourceGroupName, peeringServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the peerings prefix in the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='peeringServiceName'>
            /// The peering service name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PeeringServicePrefix>> ListByPeeringServiceAsync(this IPrefixesOperations operations, string resourceGroupName, string peeringServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPeeringServiceWithHttpMessagesAsync(resourceGroupName, peeringServiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the peerings prefix in the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PeeringServicePrefix> ListByPeeringServiceNext(this IPrefixesOperations operations, string nextPageLink)
            {
                return operations.ListByPeeringServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the peerings prefix in the resource group.
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
            public static async Task<IPage<PeeringServicePrefix>> ListByPeeringServiceNextAsync(this IPrefixesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPeeringServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}