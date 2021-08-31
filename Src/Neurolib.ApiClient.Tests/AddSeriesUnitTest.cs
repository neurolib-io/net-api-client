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
    public class AddSeriesUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestAddSeries()
        {
            AddSeries req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with valid entity id'
            resp = client.Send(new AddSeries("valid_id"));
            // it 'fails with invalid entity id'
            try
            {
                client.Send(new AddSeries("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores entity to the system'
            resp = client.Send(new AddSeries("valid_id2"));
            try
            {
                client.Send(new AddSeries("valid_id2"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestAddSeriesAsync()
        {
            AddSeries req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with valid entity id'
            resp = await client.SendAsync(new AddSeries("valid_id"));
            // it 'fails with invalid entity id'
            try
            {
                await client.SendAsync(new AddSeries("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores entity to the system'
            resp = await client.SendAsync(new AddSeries("valid_id2"));
            try
            {
                await client.SendAsync(new AddSeries("valid_id2"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
