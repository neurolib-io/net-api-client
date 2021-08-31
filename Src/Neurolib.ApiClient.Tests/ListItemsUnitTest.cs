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
    public class ListItemsUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestListItems()
        {
            ListItems req;
            IEnumerable<Item> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListItems());
            Assert.Equal (new Item[]{new Item("entity_id")},resp);
            // it 'return properties'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListItems());
            Assert.Equal(1, resp.Count());
        }

        [Fact]
        public async void TestListItemsAsync()
        {
            ListItems req;
            IEnumerable<Item> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListItems());
            Assert.Equal (new Item[]{new Item("entity_id")},resp);
            // it 'return properties'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListItems());
            Assert.Equal(1, resp.Count());
        }
    }
}
