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
    public class DeleteDetailViewBatchUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestDeleteDetailView()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteDetailView("user", "item", timestamp: UnixTimeStampToDateTime(0)),
                new DeleteDetailView("user", "item")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }

        [Fact]
        public async void TestDeleteDetailViewAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteDetailView("user", "item", timestamp: UnixTimeStampToDateTime(0)),
                new DeleteDetailView("user", "item")
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }
    }
}
