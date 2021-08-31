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
    public class ListSeriesUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestListSeries()
        {
            ListSeries req;
            IEnumerable<Series> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListSeries());
            Assert.Equal (new Series[]{new Series("entity_id")},resp);
        }

        [Fact]
        public async void TestListSeriesAsync()
        {
            ListSeries req;
            IEnumerable<Series> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListSeries());
            Assert.Equal (new Series[]{new Series("entity_id")},resp);
        }
    }
}
