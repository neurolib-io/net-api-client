using Neurolib.ApiClient.ApiRequests;
using System.Collections.Generic;
using System;

namespace Neurolib.ApiClient.Tests
{
    public class InteractionsUnitTest: NeurolibUnitTest
    {
        public InteractionsUnitTest()
        {
                Batch requests = new Batch(new Request[]{
                    new AddUser("user"),
                    new AddItem("item"),
                    new AddDetailView("user", "item", timestamp: UnixTimeStampToDateTime(0)),
                    new AddPurchase("user", "item", timestamp: UnixTimeStampToDateTime(0)),
                    new AddRating("user", "item", 1, timestamp: UnixTimeStampToDateTime(0)),
                    new AddCartAddition("user", "item", timestamp: UnixTimeStampToDateTime(0)),
                    new AddBookmark("user", "item", timestamp: UnixTimeStampToDateTime(0)),
                    new SetViewPortion("user", "item", 1, timestamp: UnixTimeStampToDateTime(0))
                });

                client.Send(requests);
        }
    }
}
