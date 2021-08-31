/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Neurolib.ApiClient.Util;

namespace Neurolib.ApiClient.Bindings
{
    /// <summary>Bookmark Binding</summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Bookmark: NeurolibBinding {
        private readonly string userId;
        /// <summary>User who bookmarked the item</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Bookmarked item</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        [JsonConverter(typeof(EpochJsonReader))]
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the bookmark as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
        [JsonConverter(typeof(EpochJsonReader))]
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
        private readonly string recommId;
        /// <summary>If this bookmark is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
        public string RecommId
        {
            get {return recommId;}
        }
        private readonly Dictionary<string, object> additionalData;
        /// <summary>A dictionary of additional data for the interaction.</summary>
        public Dictionary<string, object> AdditionalData
        {
            get {return additionalData;}
        }

        public Bookmark (string userId, string itemId, DateTime? timestamp = null, string recommId = null, Dictionary<string, object> additionalData = null)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }

        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is Bookmark))
                 return false;
             if (obj == this)
                 return true;

             Bookmark that = (Bookmark) obj;
             return new EqualsBuilder<Bookmark>(this, that)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Timestamp)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<Bookmark>(this)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Timestamp)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .HashCode;
        }
    }

}
