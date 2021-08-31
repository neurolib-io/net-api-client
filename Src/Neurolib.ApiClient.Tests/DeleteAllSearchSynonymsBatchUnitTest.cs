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
    public class DeleteAllSearchSynonymsBatchUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestDeleteAllSearchSynonyms()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteAllSearchSynonyms()
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }

        [Fact]
        public async void TestDeleteAllSearchSynonymsAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteAllSearchSynonyms()
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }
    }
}
