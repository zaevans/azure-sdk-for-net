﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Rest.ClientRuntime.Azure.TestFramework.Test.Client
{
    public partial interface ISimpleClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri { get; }

        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }
    }
}
