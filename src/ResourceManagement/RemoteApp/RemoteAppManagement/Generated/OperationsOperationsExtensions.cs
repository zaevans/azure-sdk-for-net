// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class OperationsOperationsExtensions
    {
            /// <summary>
            /// Gets the available RemoteApp operations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static OperationInfoList GetAvailableOperations(this IOperationsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IOperationsOperations)s).GetAvailableOperationsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the available RemoteApp operations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationInfoList> GetAvailableOperationsAsync( this IOperationsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<OperationInfoList> result = await operations.GetAvailableOperationsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}