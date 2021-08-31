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
    public class RecommendItemsToItemBatchUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestRecommendItemsToItem()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new RecommendItemsToItem("entity_id", "entity_id", 9),
                new RecommendItemsToItem("nonexisting", "entity_id", 9, cascadeCreate: true),
                new RecommendItemsToItem("nonexisting2", "entity_id", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){})
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
        }

        [Fact]
        public async void TestRecommendItemsToItemAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new RecommendItemsToItem("entity_id", "entity_id", 9),
                new RecommendItemsToItem("nonexisting", "entity_id", 9, cascadeCreate: true),
                new RecommendItemsToItem("nonexisting2", "entity_id", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){})
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
        }
    }
}
