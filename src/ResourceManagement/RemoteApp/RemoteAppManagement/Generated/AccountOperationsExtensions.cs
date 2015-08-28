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

    public static partial class AccountOperationsExtensions
    {
            /// <summary>
            /// Gets the account associated with the subscription id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static AccountDetailsWrapper GetAccountInfo(this IAccountOperations operations)
            {
                return Task.Factory.StartNew(s => ((IAccountOperations)s).GetAccountInfoAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the account associated with the subscription id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccountDetailsWrapper> GetAccountInfoAsync( this IAccountOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<AccountDetailsWrapper> result = await operations.GetAccountInfoWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Updates the account PrivacyUrl and WorkspaceName.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountInfo'>
            /// The new PrivacyUrl and WorkspaceName
            /// </param>
            public static AccountDetailsWrapper UpdateAccount(this IAccountOperations operations, AccountDetailsWrapper accountInfo)
            {
                return Task.Factory.StartNew(s => ((IAccountOperations)s).UpdateAccountAsync(accountInfo), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the account PrivacyUrl and WorkspaceName.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountInfo'>
            /// The new PrivacyUrl and WorkspaceName
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccountDetailsWrapper> UpdateAccountAsync( this IAccountOperations operations, AccountDetailsWrapper accountInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<AccountDetailsWrapper> result = await operations.UpdateAccountWithHttpMessagesAsync(accountInfo, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Activates billing for the account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void ActivateAccountBilling(this IAccountOperations operations)
            {
                Task.Factory.StartNew(s => ((IAccountOperations)s).ActivateAccountBillingAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Activates billing for the account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ActivateAccountBillingAsync( this IAccountOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ActivateAccountBillingWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the available billing plans for the account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static BillingPlanPropertiesWrapper Plans(this IAccountOperations operations)
            {
                return Task.Factory.StartNew(s => ((IAccountOperations)s).PlansAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the available billing plans for the account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingPlanPropertiesWrapper> PlansAsync( this IAccountOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<BillingPlanPropertiesWrapper> result = await operations.PlansWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets the supported locations to create collections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static LocationPropertiesWrapper Locations(this IAccountOperations operations)
            {
                return Task.Factory.StartNew(s => ((IAccountOperations)s).LocationsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the supported locations to create collections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocationPropertiesWrapper> LocationsAsync( this IAccountOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<LocationPropertiesWrapper> result = await operations.LocationsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}