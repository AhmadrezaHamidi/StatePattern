using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
#region snippet_NewtonsoftJsonImport
using Newtonsoft.Json;
#endregion
namespace vestaabnerMonqo.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId  _id { get; set; }
        #region snippet_BookNameProperty
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string BookName { get; set; }
        #endregion
        public string Author { get; set; }
        public string Description { get; set; }

    }
}