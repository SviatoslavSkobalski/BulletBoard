using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BulletBoard.Core.Models
{
    public class Item
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("projectId")]
        public string? ProjectId { get; set; }
        [BsonElement("title")]
        public string? Title { get; set; }
    }
}
