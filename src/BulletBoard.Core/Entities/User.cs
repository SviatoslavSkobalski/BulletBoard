﻿using BulletBoard.Core.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BulletBoard.Core.Entities
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("teamId")]
        public string? TeamId { get; set; }
        [BsonElement("username")]
        public string? Username { get; set; }
        [BsonElement("password")]
        public string? Password { get; set; }
        [BsonElement("email")]
        public string? Email { get; set; }
        [BsonElement("role")]
        public Role? Role { get; set; }
    }
}
