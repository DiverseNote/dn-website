using MongoDB.Bson;

namespace DiverseNote.Objects
{
    public interface IMongoDocument
    {
        ObjectId Id { get; set; }
    }
}
