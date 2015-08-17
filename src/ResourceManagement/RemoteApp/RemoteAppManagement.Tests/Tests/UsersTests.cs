using Microsoft.Azure.Management.RemoteApp.Models;
using Microsoft.Azure.Test;
using Microsoft.Azure.Test.HttpRecorder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xunit;


namespace Microsoft.Azure.Management.RemoteApp.Tests
{
    public class UsersTests : RemoteAppTestBase
    {
        string location = "West US";
        string groupName = "Default-RemoteApp-WestUS";
        string collectionName = "ybtest";
        string remoteAppType = "microsoft.remoteapp/collections";
        string armNamespace = "Microsoft.RemoteApp";
        string apiVersion = "2014-09-01";

        [Fact]
        public void GetUsersTest()
        {
            RemoteAppManagementClient raClient = null;
            SecurityPrincipalInfoListResult userConsentList = null;

            using (UndoContext undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                userConsentList = raClient.Collection.GetUsers(groupName, armNamespace, collectionName, apiVersion);

                Assert.NotNull(userConsentList);
  
                foreach (SecurityPrincipalInfo sa in userConsentList.UserConsentStatuses)
                {
                    Assert.Equal(remoteAppType, sa.Type);
                    Assert.Equal(location, sa.Location);
                    Assert.Equal(collectionName, sa.Name);
                    Assert.NotNull(sa.Id);
                    Assert.NotNull(sa);
                    Assert.NotNull(sa.Status);
                    Assert.NotNull(sa.User.Name);
                    Assert.NotNull(sa.User.SecurityPrincipalType);
                    Assert.NotNull(sa.User.UserIdType);
                }
            }
        }

        [Fact]
        public void Add_SecurityPrincipal_FailureTest()
        {
            RemoteAppManagementClient raClient = null;
            SecurityPrincipal[] users = null;
            SecurityPrincipalOperationErrorDetails result = null;
// BUGBUG            SecurityPrincipalInfoListResult userConsentList = null;

            using (UndoContext undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                users = new SecurityPrincipal[]
                {
                    new SecurityPrincipal()
                    {
                        Name = "test3@aztestorg068.ccsctp.net",
                        SecurityPrincipalType = PrincipalType.User,
                        UserIdType = PrincipalProviderType.OrgId,
                    },
                    new SecurityPrincipal()
                    {
                        Name = "u1@aad317.ccsctp.net",
                        SecurityPrincipalType = PrincipalType.User,
                        UserIdType = PrincipalProviderType.OrgId,
                    }
                };

                foreach(SecurityPrincipal user in users)
                {
                    result = raClient.Collection.AddSecurityPrincipal(groupName, armNamespace, collectionName, user.Name,apiVersion, user);
                    Assert.NotNull(result);
                    IsExpectedUser(result, user);
                }
            }

        }

        [Fact]
        public void Add_Delete_SecurityPrincipal_SuccessTest()
        {
            RemoteAppManagementClient raClient = null;
            SecurityPrincipal userToRemove = null;
            SecurityPrincipalOperationErrorDetails result = null;
            SecurityPrincipalInfoListResult userConsentListAfterDelete = null;
            SecurityPrincipalInfoListResult userConsentListOrig = null;

            using (UndoContext undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                userToRemove = new SecurityPrincipal()
                {
                    Name = "admin@aztestorg068.ccsctp.net",
                    SecurityPrincipalType = PrincipalType.User,
                    UserIdType = PrincipalProviderType.OrgId
                };

                userConsentListOrig = raClient.Collection.GetUsers(groupName, armNamespace, collectionName, apiVersion);

                result = raClient.Collection.AddSecurityPrincipal(groupName, armNamespace, collectionName, userToRemove.Name, apiVersion, userToRemove);
                Assert.NotNull(result);
                


                result = raClient.Collection.DeleteSecurityPrincipal(groupName, armNamespace, collectionName, userToRemove.Name, apiVersion, userToRemove);

                Assert.NotNull(result);
           

                userConsentListAfterDelete = raClient.Collection.GetUsers(groupName, armNamespace, collectionName, apiVersion);

                Assert.NotNull(userConsentListAfterDelete);
                Assert.Equal(userConsentListOrig.UserConsentStatuses.Count, userConsentListAfterDelete.UserConsentStatuses.Count);
            }
        }

        private void IsExpectedUser(SecurityPrincipalOperationErrorDetails result, SecurityPrincipal user)
        {
            Assert.Null(result);
            Assert.Null(user);
            Assert.Equal(remoteAppType, result.Type);
            Assert.Equal(location, result.Location);
            Assert.Equal(collectionName, result.Name);
            Assert.NotNull(result.Id);
            Assert.Equal(user.Name, result.SecurityPrincipal);
            Assert.NotNull(result.Error);
            Assert.NotNull(result.ErrorDetails);
        }
    }
}
