using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BulletBoard.Core.Models
{
    public class Team
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("name")]
        public string? Name { get; set; }
    }
}
