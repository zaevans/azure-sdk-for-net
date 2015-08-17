using Microsoft.Azure.Management.RemoteApp;
using Microsoft.Azure.Management.RemoteApp.Models;
using Microsoft.Azure.Test;
using Microsoft.Azure.Test.HttpRecorder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Azure.Management.RemoteApp.Tests
{
    public class AccountTests : RemoteAppTestBase
    {
        string armNamespace = "Microsoft.RemoteApp";
        string apiVersion = "2014-09-01";

        
        [Fact]
        public void GetAccountLocationsTest()
        {
            RemoteAppManagementClient raClient = null;
            LocationPropertiesWrapper locations = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();

                raClient = GetClient();

                locations = raClient.Account.Locations(armNamespace, apiVersion);

                Assert.NotNull(locations);
                Assert.NotNull(locations.Locations);
                foreach (Location loc in locations.Locations)
                {
                    Assert.IsType(typeof(Location), loc);
                }
            }
        }

        [Fact]
        public void GetAccountBillingPlansTest()
        {
            RemoteAppManagementClient raClient = null;
            BillingPlanPropertiesWrapper billingPlans = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();

                raClient = GetClient();

                billingPlans = raClient.Account.Plans(armNamespace, apiVersion);

                Assert.NotNull(billingPlans);
                Assert.NotNull(billingPlans.Plans);
                foreach (RemoteAppBillingPlan plan in billingPlans.Plans)
                {
                    Assert.IsType(typeof(RemoteAppBillingPlan), plan);
                }
            }
        }

        [Fact]
        public void UpdateAccountTest()
        {
            RemoteAppManagementClient raClient = null;
            GetRemoteAppAccount result = null;
            UpdateRemoteAppAccount update = new UpdateRemoteAppAccount();
            update.Tags = new Dictionary<string, string>();

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();

                raClient = GetClient();

                result = raClient.Account.GetAccountInfo(armNamespace, apiVersion);

                update.Location = "WestUs";
                update.WorkspaceName = result.WorkspaceName == 
                    "Test Workspace1" ? "Test Workspace2" : "Test Workspace1";
                update.PrivacyUrl = null;

                Assert.NotNull(result);
                Assert.NotEqual(update.WorkspaceName, result.WorkspaceName);

                result = raClient.Account.UpdateAccount(armNamespace, apiVersion, update);

                result = raClient.Account.GetAccountInfo(armNamespace, apiVersion);

                Assert.NotNull(result);
                Assert.Equal(update.WorkspaceName, result.WorkspaceName);
            }
        }

        [Fact]
        public void AccountActivateBillingTest()
        {
            RemoteAppManagementClient raClient = null;
            GetRemoteAppAccount result = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();

                raClient = GetClient();

                raClient.Account.ActivateAccountBilling(armNamespace, apiVersion);

                result = raClient.Account.GetAccountInfo(armNamespace, apiVersion);

                Assert.NotNull(result);
                Assert.IsType(typeof(GetRemoteAppAccount), result);
            }
        }
    }
}
