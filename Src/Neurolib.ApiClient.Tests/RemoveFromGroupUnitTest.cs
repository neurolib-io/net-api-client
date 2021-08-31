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
    public class RemoveFromGroupUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestRemoveFromGroup()
        {
            RemoveFromGroup req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail when removing item that is contained in the set'
            resp = client.Send(new RemoveFromGroup("entity_id", "item", "entity_id"));
            // it 'fails when removing item that is not contained in the set'
            try
            {
                client.Send(new RemoveFromGroup("entity_id", "item", "not_contained"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestRemoveFromGroupAsync()
        {
            RemoveFromGroup req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail when removing item that is contained in the set'
            resp = await client.SendAsync(new RemoveFromGroup("entity_id", "item", "entity_id"));
            // it 'fails when removing item that is not contained in the set'
            try
            {
                await client.SendAsync(new RemoveFromGroup("entity_id", "item", "not_contained"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
