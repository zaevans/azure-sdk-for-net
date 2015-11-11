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

    public static partial class TemplateImageOperationsExtensions
    {
            /// <summary>
            /// Gets available template images
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location where the template images are stored
            /// </param>
            public static TemplateImageList GetTemplateImages(this ITemplateImageOperations operations, string location)
            {
                return Task.Factory.StartNew(s => ((ITemplateImageOperations)s).GetTemplateImagesAsync(location), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets available template images
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location where the template images are stored
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TemplateImageList> GetTemplateImagesAsync( this ITemplateImageOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<TemplateImageList> result = await operations.GetTemplateImagesWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Uploads a template image to a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='templateImageDetails'>
            /// Details of the template image to create
            /// </param>
            /// <param name='location'>
            /// Location of the template image
            /// </param>
            /// <param name='templateImageName'>
            /// The name of the template image
            /// </param>
            public static TemplateImage SetTemplateImage(this ITemplateImageOperations operations, TemplateImageCreateDetails templateImageDetails, string location, string templateImageName)
            {
                return Task.Factory.StartNew(s => ((ITemplateImageOperations)s).SetTemplateImageAsync(templateImageDetails, location, templateImageName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Uploads a template image to a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='templateImageDetails'>
            /// Details of the template image to create
            /// </param>
            /// <param name='location'>
            /// Location of the template image
            /// </param>
            /// <param name='templateImageName'>
            /// The name of the template image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TemplateImage> SetTemplateImageAsync( this ITemplateImageOperations operations, TemplateImageCreateDetails templateImageDetails, string location, string templateImageName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<TemplateImage> result = await operations.SetTemplateImageWithHttpMessagesAsync(templateImageDetails, location, templateImageName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Uploads a template image to a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='templateImageDetails'>
            /// Details of the template image to create
            /// </param>
            /// <param name='location'>
            /// Location of the template image
            /// </param>
            /// <param name='templateImageName'>
            /// The name of the template image
            /// </param>
            public static TemplateImage BeginSetTemplateImage(this ITemplateImageOperations operations, TemplateImageCreateDetails templateImageDetails, string location, string templateImageName)
            {
                return Task.Factory.StartNew(s => ((ITemplateImageOperations)s).BeginSetTemplateImageAsync(templateImageDetails, location, templateImageName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Uploads a template image to a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='templateImageDetails'>
            /// Details of the template image to create
            /// </param>
            /// <param name='location'>
            /// Location of the template image
            /// </param>
            /// <param name='templateImageName'>
            /// The name of the template image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TemplateImage> BeginSetTemplateImageAsync( this ITemplateImageOperations operations, TemplateImageCreateDetails templateImageDetails, string location, string templateImageName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<TemplateImage> result = await operations.BeginSetTemplateImageWithHttpMessagesAsync(templateImageDetails, location, templateImageName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Removes a template image from a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the template image
            /// </param>
            /// <param name='templateImageName'>
            /// The name of the template image
            /// </param>
            public static void DeleteTemplateImage(this ITemplateImageOperations operations, string location, string templateImageName)
            {
                Task.Factory.StartNew(s => ((ITemplateImageOperations)s).DeleteTemplateImageAsync(location, templateImageName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a template image from a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the template image
            /// </param>
            /// <param name='templateImageName'>
            /// The name of the template image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteTemplateImageAsync( this ITemplateImageOperations operations, string location, string templateImageName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteTemplateImageWithHttpMessagesAsync(location, templateImageName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Removes a template image from a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the template image
            /// </param>
            /// <param name='templateImageName'>
            /// The name of the template image
            /// </param>
            public static void BeginDeleteTemplateImage(this ITemplateImageOperations operations, string location, string templateImageName)
            {
                Task.Factory.StartNew(s => ((ITemplateImageOperations)s).BeginDeleteTemplateImageAsync(location, templateImageName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a template image from a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the template image
            /// </param>
            /// <param name='templateImageName'>
            /// The name of the template image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteTemplateImageAsync( this ITemplateImageOperations operations, string location, string templateImageName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteTemplateImageWithHttpMessagesAsync(location, templateImageName, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
