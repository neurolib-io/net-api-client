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
    public class MergeUsersUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestMergeUsers()
        {
            MergeUsers req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing users'
            resp2 = client.Send(new AddUser("target"));
            resp = client.Send(new MergeUsers("target", "entity_id"));
            // it 'fails with nonexisting user'
            try
            {
                client.Send(new MergeUsers("nonex_id", "entity_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestMergeUsersAsync()
        {
            MergeUsers req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing users'
            resp2 = await client.SendAsync(new AddUser("target"));
            resp = await client.SendAsync(new MergeUsers("target", "entity_id"));
            // it 'fails with nonexisting user'
            try
            {
                await client.SendAsync(new MergeUsers("nonex_id", "entity_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
