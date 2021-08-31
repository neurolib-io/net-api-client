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
    public class ListUserViewPortionsBatchUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListUserViewPortions()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUserViewPortions("user")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<ViewPortion>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<ViewPortion>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<ViewPortion>) batchResponse[0]).ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListUserViewPortionsAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUserViewPortions("user")
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<ViewPortion>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<ViewPortion>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<ViewPortion>) batchResponse[0]).ElementAt(0).UserId);
        }
    }
}
