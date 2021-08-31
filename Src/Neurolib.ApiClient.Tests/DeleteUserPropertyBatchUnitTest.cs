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
    public class DeleteUserPropertyBatchUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestDeleteUserProperty()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteUserProperty("int_property"),
                new DeleteUserProperty("int_property"),
                new DeleteUserProperty("***not_valid$$$"),
                new DeleteUserProperty("not_existing")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
        }

        [Fact]
        public async void TestDeleteUserPropertyAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteUserProperty("int_property"),
                new DeleteUserProperty("int_property"),
                new DeleteUserProperty("***not_valid$$$"),
                new DeleteUserProperty("not_existing")
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
