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
    public class AddSeriesBatchUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestAddSeries()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddSeries("valid_id"),
                new AddSeries("***not_valid$$$"),
                new AddSeries("valid_id2"),
                new AddSeries("valid_id2")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }

        [Fact]
        public async void TestAddSeriesAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddSeries("valid_id"),
                new AddSeries("***not_valid$$$"),
                new AddSeries("valid_id2"),
                new AddSeries("valid_id2")
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
