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
    public class AddItemPropertyBatchUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestAddItemProperty()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddItemProperty("number", "int"),
                new AddItemProperty("str", "string"),
                new AddItemProperty("prop", "integer"),
                new AddItemProperty("number2", "int"),
                new AddItemProperty("number2", "int")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(4));
        }

        [Fact]
        public async void TestAddItemPropertyAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddItemProperty("number", "int"),
                new AddItemProperty("str", "string"),
                new AddItemProperty("prop", "integer"),
                new AddItemProperty("number2", "int"),
                new AddItemProperty("number2", "int")
            };

            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(4));
        }
    }
}
