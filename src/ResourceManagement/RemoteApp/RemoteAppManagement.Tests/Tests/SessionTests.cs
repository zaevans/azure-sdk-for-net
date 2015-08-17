using Microsoft.Azure.Management.RemoteApp;
using Microsoft.Azure.Management.RemoteApp.Models;
using Microsoft.Azure.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Azure.Management.RemoteApp.Tests
{
    public class SessionTests : RemoteAppTestBase
    {
        const string groupName = "Default-RemoteApp-WestUS";
        const string collectionName = "ybtest";
        const string userUpn = "test";
        string armNamespace = "Microsoft.RemoteApp";
        string apiVersion = "2014-09-01";

        [Fact]
        public void GetSessionTest()
        {
            RemoteAppManagementClient raClient = null;
            IList<SessionWrapper> sessions = null;

            raClient = GetClient();

            sessions = raClient.Collection.SessionList(groupName, armNamespace, collectionName, apiVersion);

            Assert.NotNull(sessions);
            foreach (SessionWrapper session in sessions)
            {
                Assert.NotNull(session.UserUpn);
            }
        }

        [Fact]
        public void LogOffSessionTest()
        {
            RemoteAppManagementClient raClient = null;
            IList<SessionWrapper> sessions = null;

            raClient = GetClient();

            raClient.Collection.SessionLogOff(groupName, armNamespace, collectionName, userUpn, apiVersion);

            sessions = raClient.Collection.SessionList(groupName, armNamespace, collectionName, apiVersion);

            Assert.NotNull(sessions);
            foreach (SessionWrapper session in sessions)
            {
                Assert.NotNull(session.UserUpn);
            }
        }

        [Fact]
        public void DisconnectSessionTest()
        {
            RemoteAppManagementClient raClient = null;
            IList<SessionWrapper> sessions = null;

            raClient = GetClient();

            raClient.Collection.SessionDisconnect(groupName, armNamespace, collectionName, userUpn, apiVersion);

            sessions = raClient.Collection.SessionList(groupName, armNamespace, collectionName, apiVersion);

            Assert.NotNull(sessions);
            foreach (SessionWrapper session in sessions)
            {
                Assert.NotNull(session.UserUpn);
            }
        }

        [Fact]
        public void MessageSessionTest()
        {
            RemoteAppManagementClient raClient = null;
            IList<SessionWrapper> sessions = null;

            raClient = GetClient();

            SessionSendMessageCommandParameter param = new SessionSendMessageCommandParameter();
            param.Message = "hello";

            raClient.Collection.SessionSendMessage(groupName, armNamespace, collectionName, userUpn, apiVersion, param);

            sessions = raClient.Collection.SessionList(groupName, armNamespace, collectionName, apiVersion);

            Assert.NotNull(sessions);
            foreach (SessionWrapper session in sessions)
            {
                Assert.NotNull(session.UserUpn);
            }
        }
    }
}
