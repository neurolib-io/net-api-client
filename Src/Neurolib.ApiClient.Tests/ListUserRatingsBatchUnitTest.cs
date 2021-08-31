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
    public class ListUserRatingsBatchUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListUserRatings()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUserRatings("user")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<Rating>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<Rating>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<Rating>) batchResponse[0]).ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListUserRatingsAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUserRatings("user")
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<Rating>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<Rating>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<Rating>) batchResponse[0]).ElementAt(0).UserId);
        }
    }
}