using DiverseNote.Data.EntityRepositories.Interfaces;
using DiverseNote.Objects;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using DiverseNote.Data.Extensions;

namespace DiverseNote.Data.EntityRepositories
{
    public sealed class RecruiterRepository : MongoRepository<Recruiter>, IRecruiterRepository
    {
        public RecruiterRepository()
        {
            DocumentCollectionName = GetCollectionTypeName();
            SetMappings();
        }

        protected override string GetCollectionTypeName()
        {
            return typeof(Recruiter).GetCollectionName();
        }

        protected override void SetMappings()
        {
            BsonClassMap.RegisterClassMap<Recruiter>(cm =>
            {
                cm.AutoMap();
                cm.IdMemberMap.SetSerializer(new StringSerializer(BsonType.ObjectId));
            });
        }
    }
}
