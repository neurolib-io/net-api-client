using System;
using System.Collections.Generic;
using Xunit;
using Neurolib.ApiClient;
using Neurolib.ApiClient.ApiRequests;
using Neurolib.ApiClient.Bindings;

namespace Neurolib.ApiClient.Tests
{
    public class GetItemValuesUnitTest: NeurolibUnitTest
    {

        [Fact]
        public void TestGetItemValues()
        {
            GetItemValues req = new GetItemValues("entity_id");
            Item resp = client.Send(req);
            Assert.Equal ((long)42, (long)resp.Values["int_property"]);
            Assert.Equal ("hello",resp.Values["str_property"]);
        }

        [Fact]
        public async void TestGetItemValuesAsync()
        {
            GetItemValues req = new GetItemValues("entity_id");
            Item resp = await client.SendAsync(req);
            Assert.Equal ((long)42, (long)resp.Values["int_property"]);
            Assert.Equal ("hello",resp.Values["str_property"]);
        }

    }
}
