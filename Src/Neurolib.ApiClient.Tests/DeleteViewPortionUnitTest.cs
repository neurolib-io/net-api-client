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
    public class DeleteViewPortionUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestDeleteViewPortion()
        {
            DeleteViewPortion req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing entity id'
            resp = client.Send(new DeleteViewPortion("user", "item"));
            try
            {
                client.Send(new DeleteViewPortion("user", "item"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestDeleteViewPortionAsync()
        {
            DeleteViewPortion req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing entity id'
            resp = await client.SendAsync(new DeleteViewPortion("user", "item"));
            try
            {
                await client.SendAsync(new DeleteViewPortion("user", "item"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
