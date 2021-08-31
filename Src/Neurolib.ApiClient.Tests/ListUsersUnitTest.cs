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
    public class ListUsersUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestListUsers()
        {
            ListUsers req;
            IEnumerable<User> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListUsers());
            Assert.Equal (new User[]{new User("entity_id")},resp);
            // it 'return properties'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListUsers());
            Assert.Equal(1, resp.Count());
        }

        [Fact]
        public async void TestListUsersAsync()
        {
            ListUsers req;
            IEnumerable<User> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListUsers());
            Assert.Equal (new User[]{new User("entity_id")},resp);
            // it 'return properties'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListUsers());
            Assert.Equal(1, resp.Count());
        }
    }
}
