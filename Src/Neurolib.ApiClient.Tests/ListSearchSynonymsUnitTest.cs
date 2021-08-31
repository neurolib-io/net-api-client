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
    public class ListSearchSynonymsUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestListSearchSynonyms()
        {
            ListSearchSynonyms req;
            ListSearchSynonymsResponse resp;
            Object resp2;
            // it 'lists search synonyms'
            System.Threading.Thread.Sleep(10000);
            resp2 = client.Send(new AddSearchSynonym("sci-fi", "science fiction"));
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListSearchSynonyms());
            Assert.Equal(1, resp.Synonyms.Count());
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListSearchSynonyms(count: 10, offset: 1));
            Assert.Equal(0, resp.Synonyms.Count());
        }

        [Fact]
        public async void TestListSearchSynonymsAsync()
        {
            ListSearchSynonyms req;
            ListSearchSynonymsResponse resp;
            Object resp2;
            // it 'lists search synonyms'
            System.Threading.Thread.Sleep(10000);
            resp2 = await client.SendAsync(new AddSearchSynonym("sci-fi", "science fiction"));
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListSearchSynonyms());
            Assert.Equal(1, resp.Synonyms.Count());
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListSearchSynonyms(count: 10, offset: 1));
            Assert.Equal(0, resp.Synonyms.Count());
        }
    }
}
