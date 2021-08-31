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
    /// <summary>Delete search synonym</summary>
    /// <remarks>Deletes synonym of given `id` and this synonym is no longer taken into account in the [Search items](https://www.neurolib.io/pages/documentation/api.html#search-items).
    /// </remarks>
    public class DeleteSearchSynonym : Request
    {
        private readonly string id;
        /// <summary>ID of the synonym that should be deleted.</summary>
        public string Id
        {
            get {return id;}
        }

        /// <summary>Construct the request</summary>
        /// <param name="id">ID of the synonym that should be deleted.</param>
        public DeleteSearchSynonym (string id): base(HttpMethod.Delete, 10000)
        {
            this.id = id;
        }

        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/synonyms/items/{0}", Id);
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
