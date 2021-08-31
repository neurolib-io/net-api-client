/*
 This file is auto-generated, do not edit
*/


using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Neurolib.ApiClient.ApiRequests;
using Neurolib.ApiClient.Bindings;

namespace Neurolib.ApiClient.Tests
{
    public class ListGroupItemsUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestListGroupItems()
        {
            ListGroupItems req;
            IEnumerable<GroupItem> resp;
            Object resp2;
            // it 'lists set items'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListGroupItems("entity_id"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("entity_id",resp.ElementAt(0).ItemId);
            Assert.Equal ("item",resp.ElementAt(0).ItemType);
        }

        [Fact]
        public async void TestListGroupItemsAsync()
        {
            ListGroupItems req;
            IEnumerable<GroupItem> resp;
            Object resp2;
            // it 'lists set items'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListGroupItems("entity_id"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("entity_id",resp.ElementAt(0).ItemId);
            Assert.Equal ("item",resp.ElementAt(0).ItemType);
        }
    }
}
