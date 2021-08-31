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
    public class ListUserPropertiesUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestListUserProperties()
        {
            ListUserProperties req;
            IEnumerable<PropertyInfo> resp;
            Object resp2;
            // it 'lists properties'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListUserProperties());
            Assert.Equal(2, resp.Count());
        }

        [Fact]
        public async void TestListUserPropertiesAsync()
        {
            ListUserProperties req;
            IEnumerable<PropertyInfo> resp;
            Object resp2;
            // it 'lists properties'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListUserProperties());
            Assert.Equal(2, resp.Count());
        }
    }
}
