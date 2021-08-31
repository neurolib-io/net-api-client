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
    public class DeleteItemPropertyUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestDeleteItemProperty()
        {
            DeleteItemProperty req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing property'
            resp = client.Send(new DeleteItemProperty("int_property"));
            try
            {
                client.Send(new DeleteItemProperty("int_property"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid property'
            try
            {
                client.Send(new DeleteItemProperty("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with non-existing property'
            try
            {
                client.Send(new DeleteItemProperty("not_existing"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestDeleteItemPropertyAsync()
        {
            DeleteItemProperty req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing property'
            resp = await client.SendAsync(new DeleteItemProperty("int_property"));
            try
            {
                await client.SendAsync(new DeleteItemProperty("int_property"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid property'
            try
            {
                await client.SendAsync(new DeleteItemProperty("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with non-existing property'
            try
            {
                await client.SendAsync(new DeleteItemProperty("not_existing"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
