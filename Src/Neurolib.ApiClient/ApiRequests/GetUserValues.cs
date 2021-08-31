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
    /// <summary>Get user values</summary>
    /// <remarks>Get all the current property values of a given user.
    /// </remarks>
    public class GetUserValues : Request
    {
        private readonly string userId;
        /// <summary>ID of the user properties of which are to be obtained.
        /// </summary>
        public string UserId
        {
            get {return userId;}
        }

        /// <summary>Construct the request</summary>
        /// <param name="userId">ID of the user properties of which are to be obtained.
        /// </param>
        public GetUserValues (string userId): base(HttpMethod.Get, 1000)
        {
            this.userId = userId;
        }

        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/users/{0}", UserId);
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
