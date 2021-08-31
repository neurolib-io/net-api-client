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
    public class ItemBasedRecommendationBatchUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestItemBasedRecommendation()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ItemBasedRecommendation("entity_id", 9),
                new ItemBasedRecommendation("nonexisting", 9, cascadeCreate: true),
                new ItemBasedRecommendation("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){})
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(9, ((IEnumerable<Recommendation>) batchResponse[0]).Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(9, ((IEnumerable<Recommendation>) batchResponse[1]).Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(9, ((IEnumerable<Recommendation>) batchResponse[2]).Count());
        }

        [Fact]
        public async void TestItemBasedRecommendationAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ItemBasedRecommendation("entity_id", 9),
                new ItemBasedRecommendation("nonexisting", 9, cascadeCreate: true),
                new ItemBasedRecommendation("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){})
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(9, ((IEnumerable<Recommendation>) batchResponse[0]).Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(9, ((IEnumerable<Recommendation>) batchResponse[1]).Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(9, ((IEnumerable<Recommendation>) batchResponse[2]).Count());
        }
    }
}
