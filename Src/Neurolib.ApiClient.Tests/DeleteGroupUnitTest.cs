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
    public class DeleteGroupUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestDeleteGroup()
        {
            DeleteGroup req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing entity id'
            resp = client.Send(new DeleteGroup("entity_id"));
            try
            {
                client.Send(new DeleteGroup("entity_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid entity id'
            try
            {
                client.Send(new DeleteGroup("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with non-existing entity'
            try
            {
                client.Send(new DeleteGroup("valid_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestDeleteGroupAsync()
        {
            DeleteGroup req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing entity id'
            resp = await client.SendAsync(new DeleteGroup("entity_id"));
            try
            {
                await client.SendAsync(new DeleteGroup("entity_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid entity id'
            try
            {
                await client.SendAsync(new DeleteGroup("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with non-existing entity'
            try
            {
                await client.SendAsync(new DeleteGroup("valid_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
