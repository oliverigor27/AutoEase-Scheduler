using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Autoease.Domain.Entities;

public class BaseEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; private set; }
    public DateTime Created_At { get; private set; }

    public BaseEntity ()
    {
        Id = new Guid();
        Created_At = new DateTime();
    }
}