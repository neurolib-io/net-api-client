/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using Neurolib.ApiClient.Bindings;
using Neurolib.ApiClient.Util;


namespace Neurolib.ApiClient.ApiRequests
{
    /// <summary>Delete detail view</summary>
    /// <remarks>Deletes an existing detail view uniquely specified by (`userId`, `itemId`, and `timestamp`) or all the detail views with given `userId` and `itemId` if `timestamp` is omitted.
    /// </remarks>
    public class DeleteDetailView : Request
    {
        private readonly string userId;
        /// <summary>ID of the user who made the detail view.</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>ID of the item of which the details were viewed.</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly DateTime? timestamp;
        /// <summary>Unix timestamp of the detail view. If the `timestamp` is omitted, then all the detail views with given `userId` and `itemId` are deleted.</summary>
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }

        /// <summary>Construct the request</summary>
        /// <param name="userId">ID of the user who made the detail view.</param>
        /// <param name="itemId">ID of the item of which the details were viewed.</param>
        /// <param name="timestamp">Unix timestamp of the detail view. If the `timestamp` is omitted, then all the detail views with given `userId` and `itemId` are deleted.</param>
        public DeleteDetailView (string userId, string itemId, DateTime? timestamp = null): base(HttpMethod.Delete, 1000)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
        }

        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/detailviews/";
        }

        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
                {"userId", this.UserId},
                {"itemId", this.ItemId}
            };
            if (this.Timestamp.HasValue)
                parameters["timestamp"] = ConvertToUnixTimestamp(this.Timestamp.Value);
            return parameters;
        }

        /// <summary>Get body parameters</summary>
        /// <returns>Dictionary containing  values of body parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> BodyParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {

            };
            return parameters;
        }

    }
}
