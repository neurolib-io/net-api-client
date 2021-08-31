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
    public class DeletePurchaseUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestDeletePurchase()
        {
            DeletePurchase req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing entity id'
            resp = client.Send(new DeletePurchase("user", "item", timestamp: UnixTimeStampToDateTime(0)));
            try
            {
                client.Send(new DeletePurchase("user", "item"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestDeletePurchaseAsync()
        {
            DeletePurchase req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing entity id'
            resp = await client.SendAsync(new DeletePurchase("user", "item", timestamp: UnixTimeStampToDateTime(0)));
            try
            {
                await client.SendAsync(new DeletePurchase("user", "item"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
