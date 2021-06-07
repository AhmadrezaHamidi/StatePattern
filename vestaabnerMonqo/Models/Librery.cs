using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
#region snippet_NewtonsoftJsonImport
using Newtonsoft.Json;
#endregion
namespace vestaabnerMonqo.Models
{
    public class Librery
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }

        #region snippet_BookNameProperty
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string LibreryName { get; set; }
        #endregion
        public string userId { get; set; }
        public List<string> ShelveId { get; set; }

    }
}