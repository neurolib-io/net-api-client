using System.Linq;
using Xunit;
using Neurolib.ApiClient.ApiRequests;
using Neurolib.ApiClient.Bindings;

namespace Neurolib.ApiClient.Tests
{
    public class GetUserValuesBatchUnitTest: NeurolibUnitTest
    {

        [Fact]
        public void TestGetUserValues()
        {
            Request[] requests = new Request[] {
                new GetUserValues("entity_id")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ((long)42, (long) ((User) batchResponse[0]).Values["int_property"]);
            Assert.Equal ("hello",((User) batchResponse[0]).Values["str_property"]);
        }

        [Fact]
        public async void TestGetUserValuesAsync()
        {
            Request[] requests = new Request[] {
                new GetUserValues("entity_id")
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ((long)42, (long) ((User) batchResponse[0]).Values["int_property"]);
            Assert.Equal ("hello",((User) batchResponse[0]).Values["str_property"]);
        }

    }
}
