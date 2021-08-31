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
    public class DeleteAllSearchSynonymsUnitTest: NeurolibUnitTest
    {

        [Fact]
        public  void TestDeleteAllSearchSynonyms()
        {
            DeleteAllSearchSynonyms req;
            NeurolibBinding resp;
            Object resp2;
            // it 'deletes all search synonyms'
            resp = client.Send(new DeleteAllSearchSynonyms());
        }

        [Fact]
        public async void TestDeleteAllSearchSynonymsAsync()
        {
            DeleteAllSearchSynonyms req;
            NeurolibBinding resp;
            Object resp2;
            // it 'deletes all search synonyms'
            resp = await client.SendAsync(new DeleteAllSearchSynonyms());
        }
    }
}
