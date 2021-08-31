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
    public class SetItemValuesUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestSetItemValues()
        {
            SetItemValues req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing entity and property'
            resp = client.Send(new SetItemValues("entity_id", new Dictionary<string, object>(){{"int_property",5}}));
            // it 'does not fail with non-ASCII string'
            resp = client.Send(new SetItemValues("entity_id", new Dictionary<string, object>(){{"str_property","šřžذ的‎"}}));
            // it 'sets multiple properties'
            resp = client.Send(new SetItemValues("entity_id", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}}));
            // it 'does not fail with !cascadeCreate'
            resp = client.Send(new SetItemValues("new_entity", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}, {"!cascadeCreate",true}}));
            // it 'does not fail with cascadeCreate optional parameter'
            resp = client.Send(new SetItemValues("new_entity2", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}}, cascadeCreate: true));
            // it 'fails with nonexisting entity'
            try
            {
                client.Send(new SetItemValues("nonexisting", new Dictionary<string, object>(){{"int_property",5}}));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestSetItemValuesAsync()
        {
            SetItemValues req;
            NeurolibBinding resp;
            Object resp2;
            // it 'does not fail with existing entity and property'
            resp = await client.SendAsync(new SetItemValues("entity_id", new Dictionary<string, object>(){{"int_property",5}}));
            // it 'does not fail with non-ASCII string'
            resp = await client.SendAsync(new SetItemValues("entity_id", new Dictionary<string, object>(){{"str_property","šřžذ的‎"}}));
            // it 'sets multiple properties'
            resp = await client.SendAsync(new SetItemValues("entity_id", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}}));
            // it 'does not fail with !cascadeCreate'
            resp = await client.SendAsync(new SetItemValues("new_entity", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}, {"!cascadeCreate",true}}));
            // it 'does not fail with cascadeCreate optional parameter'
            resp = await client.SendAsync(new SetItemValues("new_entity2", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}}, cascadeCreate: true));
            // it 'fails with nonexisting entity'
            try
            {
                await client.SendAsync(new SetItemValues("nonexisting", new Dictionary<string, object>(){{"int_property",5}}));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
