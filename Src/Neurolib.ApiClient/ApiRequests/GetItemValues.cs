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
    /// <summary>Get item values</summary>
    /// <remarks>Get all the current property values of a given item.
    /// </remarks>
    public class GetItemValues : Request
    {
        private readonly string itemId;
        /// <summary>ID of the item properties of which are to be obtained.
        /// </summary>
        public string ItemId
        {
            get {return itemId;}
        }

        /// <summary>Construct the request</summary>
        /// <param name="itemId">ID of the item properties of which are to be obtained.
        /// </param>
        public GetItemValues (string itemId): base(HttpMethod.Get, 1000)
        {
            this.itemId = itemId;
        }

        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/items/{0}", ItemId);
        }

        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {

            };
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
