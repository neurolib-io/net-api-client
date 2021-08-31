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
    public class ListSeriesBatchUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestListSeries()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListSeries()
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal (new Series[]{new Series("entity_id")},((IEnumerable<Series>) batchResponse[0]));
        }

        [Fact]
        public async void TestListSeriesAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListSeries()
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal (new Series[]{new Series("entity_id")},((IEnumerable<Series>) batchResponse[0]));
        }
    }
}
