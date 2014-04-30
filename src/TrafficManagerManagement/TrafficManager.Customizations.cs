//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.WindowsAzure.Management.TrafficManager
{
    public partial class TrafficManagerManagementClient
    {
        public static TrafficManagerManagementClient Create(IDictionary<string, object> settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }

            SubscriptionCloudCredentials credentials = ConfigurationHelper.GetCredentials<SubscriptionCloudCredentials>(settings);

            Uri baseUri = ConfigurationHelper.GetUri(settings, "BaseUri", false);

            return baseUri != null ?
                new TrafficManagerManagementClient(credentials, baseUri) :
                new TrafficManagerManagementClient(credentials);
        }

        protected override void Clone(ServiceClient<TrafficManagerManagementClient> client)
        {
            base.Clone(client);
            TrafficManagerManagementClient management = client as TrafficManagerManagementClient;
            if (management != null)
            {
                management._credentials = Credentials;
                management._baseUri = BaseUri;
                management.Credentials.InitializeServiceClient(management);
            }
        }

        public override TrafficManagerManagementClient WithHandler(DelegatingHandler handler)
        {
            return (TrafficManagerManagementClient)WithHandler(new TrafficManagerManagementClient(), handler);
        }
    }
}