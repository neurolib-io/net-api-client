using System.Linq;
using Xunit;
using Neurolib.ApiClient.ApiRequests;
using Neurolib.ApiClient.Bindings;

namespace Neurolib.ApiClient.Tests
{
    public class GetItemValuesBatchUnitTest: NeurolibUnitTest
    {

        [Fact]
        public void TestGetItemValues()
        {
            Request[] requests = new Request[] {
                new GetItemValues("entity_id")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ((long)42,(long)((Item) batchResponse[0]).Values["int_property"]);
            Assert.Equal ("hello",((Item) batchResponse[0]).Values["str_property"]);
        }

        [Fact]
        public async void TestGetItemValuesAsync()
        {
            Request[] requests = new Request[] {
                new GetItemValues("entity_id")
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ((long)42,(long)((Item) batchResponse[0]).Values["int_property"]);
            Assert.Equal ("hello",((Item) batchResponse[0]).Values["str_property"]);
        }

    }
}
