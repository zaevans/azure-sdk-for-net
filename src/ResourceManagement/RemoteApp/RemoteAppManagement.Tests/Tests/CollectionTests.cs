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
    public class CollectionTests : RemoteAppTestBase
    {
        string groupName = "Default-RemoteApp-WestUS";

        [Fact]
        public void GetCollectionListTest()
        {
            RemoteAppManagementClient raClient = null;
            IList<Collection> collections = null;

            using (var undoContext = UndoContext.Current)
            {
                undoContext.Start();
                raClient = GetClient();

                collections = raClient.Collection.List(groupName);

                Assert.NotNull(collections);
                Assert.NotEmpty(collections);

                foreach (Collection col in collections)
                {
                    Assert.Equal("microsoft.remoteapp/collections", col.Type);
                }
            }
        }

        //[Fact]
        //public void GetCollectionTest()
        //{
        //    RemoteAppManagementClient raClient = null;
        //    GetCollectionOperationResult collection = null;

        //    using (var undoContext = UndoContext.Current)
        //    {
        //        undoContext.Start();
        //        raClient = GetClient();

        //        collection = raClient.CollectionOperations.Get("Microsoft.RemoteApp", "testcol2");

        //        Assert.NotNull(collection);
        //        Assert.Equal(HttpStatusCode.OK, collection.StatusCode);
        //        Assert.NotNull(collection.Collection);
        //        Assert.NotNull(collection.CollectionOperations.Properties);
        //        Assert.Equal("collections", collection.CollectionOperations.Type);
        //        Assert.Equal("testcol1", collection.CollectionOperations.Properties.Name);
        //    }
        //}
    }
}
