using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
#region snippet_NewtonsoftJsonImport
using Newtonsoft.Json;
#endregion
namespace vestaabnerMonqo.Models
{
    public class Shelve
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        #region snippet_BookNameProperty
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string ShelveName { get; set; }
        #endregion
        public List<string> Books { get; set; }

    }
}