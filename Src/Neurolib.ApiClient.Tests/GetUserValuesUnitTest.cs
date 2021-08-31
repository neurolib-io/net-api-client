using System;
using System.Collections.Generic;
using Xunit;
using Neurolib.ApiClient;
using Neurolib.ApiClient.ApiRequests;
using Neurolib.ApiClient.Bindings;

namespace Neurolib.ApiClient.Tests
{
    public class GetUserValuesUnitTest: NeurolibUnitTest
    {
        [Fact]
        public void TestGetUserValues()
        {
            GetUserValues req = new GetUserValues("entity_id");
            User resp = client.Send(req);
            Assert.Equal ((long)42, (long)resp.Values["int_property"]);
            Assert.Equal ("hello",resp.Values["str_property"]);
        }

        [Fact]
        public async void TestGetUserValuesAsync()
        {
            GetUserValues req = new GetUserValues("entity_id");
            User resp = await client.SendAsync(req);
            Assert.Equal ((long)42, (long)resp.Values["int_property"]);
            Assert.Equal ("hello",resp.Values["str_property"]);
        }
    }
}
