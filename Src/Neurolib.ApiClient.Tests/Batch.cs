using System.Collections.Generic;
using System.Linq;
using Xunit;
using Neurolib.ApiClient.ApiRequests;

namespace Neurolib.ApiClient.Tests
{
    public class BatchUnitTest: NeurolibUnitTest
    {

        [Fact]
        public void TestLargeBatch()
        {
            client.Send(new AddItemProperty("batch_test", "boolean"));
            const int NUM_ITEMS = 14783;
            var reqs = Enumerable.Range(0, NUM_ITEMS).Select(i => new SetItemValues(string.Format("item-{0}", i),
                                                                new Dictionary<string, object>{{"batch_test", true}},
                                                                cascadeCreate: true));

            var responses = client.Send(new Batch(reqs));
            Assert.Equal(NUM_ITEMS, responses.Responses.Count());
            foreach(var statusCode in responses.StatusCodes)
                Assert.Equal(200, (int)statusCode);
        }

        [Fact]
        public async void TestLargeBatchAsync()
        {
            await client.SendAsync(new AddItemProperty("batch_test", "boolean"));
            const int NUM_ITEMS = 14783;
            var reqs = Enumerable.Range(0, NUM_ITEMS).Select(i => new SetItemValues(string.Format("item-{0}", i),
                                                                new Dictionary<string, object>{{"batch_test", true}},
                                                                cascadeCreate: true));

            var responses = await client.SendAsync(new Batch(reqs));
            Assert.Equal(NUM_ITEMS, responses.Responses.Count());
            foreach(var statusCode in responses.StatusCodes)
                Assert.Equal(200, (int)statusCode);
        }
    }
}
