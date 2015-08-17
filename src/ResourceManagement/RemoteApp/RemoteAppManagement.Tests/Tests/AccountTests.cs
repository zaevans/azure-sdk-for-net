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
        [Fact]
        public void GetAccountLocationsTest()
        {
            RemoteAppManagementClient raClient = null;
            LocationPropertiesWrapper locations = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();

                raClient = GetClient();

                locations = raClient.Account.Locations();

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
                billingPlans = raClient.Account.Plans();

                Assert.NotNull(billingPlans);
                Assert.NotNull(billingPlans.Plans);
                foreach (BillingPlan plan in billingPlans.Plans)
                {
                    Assert.IsType(typeof(BillingPlan), plan);
                }
            }
        }

        [Fact]
        public void UpdateAccountTest()
        {
            RemoteAppManagementClient raClient = null;
            AccountDetailsWrapper result = null;
            AccountDetailsWrapper update = new AccountDetailsWrapper();
            update.Tags = new Dictionary<string, string>();

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();

                raClient = GetClient();

                result = raClient.Account.GetAccountInfo();

                update.Location = "WestUs";
                update.WorkspaceName = result.WorkspaceName == 
                    "Test Workspace1" ? "Test Workspace2" : "Test Workspace1";
                update.PrivacyUrl = null;

                Assert.NotNull(result);
                Assert.NotEqual(update.WorkspaceName, result.WorkspaceName);

                result = raClient.Account.UpdateAccount(update);

                result = raClient.Account.GetAccountInfo();

                Assert.NotNull(result);
                Assert.Equal(update.WorkspaceName, result.WorkspaceName);
            }
        }

        [Fact]
        public void AccountActivateBillingTest()
        {
            RemoteAppManagementClient raClient = null;
            AccountDetailsWrapper result = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();

                raClient = GetClient();

                raClient.Account.ActivateAccountBilling();

                result = raClient.Account.GetAccountInfo();

                Assert.NotNull(result);
                Assert.IsType(typeof(AccountDetailsWrapper), result);
            }
        }
    }
}
