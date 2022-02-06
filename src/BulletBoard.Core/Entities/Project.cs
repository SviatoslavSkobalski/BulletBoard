using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BulletBoard.Core.Models
{
    public class Project
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("teamId")]
        public string? TeamId { get; set; }
        [BsonElement("name")]
        public string? Name { get; set; }
    }
}
