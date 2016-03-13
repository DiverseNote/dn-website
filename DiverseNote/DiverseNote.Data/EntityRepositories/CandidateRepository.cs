using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DiverseNote.Data.EntityRepositories.Interfaces;
using DiverseNote.Objects;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using DiverseNote.Data.Extensions;
using MongoDB.Driver;

namespace DiverseNote.Data.EntityRepositories
{
    public sealed class CandidateRepository : MongoRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository()
        {
            DocumentCollectionName = GetCollectionTypeName();
            SetMappings();
        }

        public IEnumerable<Candidate> Find(Expression<Func<Candidate, bool>> whereClause, int pageNumber, int pageSize)
        {
            return Database.GetCollection<Candidate>(DocumentCollectionName)
                .Find(whereClause).Skip(pageNumber > 0 ? ((pageNumber - 1) * pageSize) : 0)
                .Limit(pageSize).ToEnumerable();
        }

        protected override string GetCollectionTypeName()
        {
            return typeof(Candidate).GetCollectionName();
        }

        protected override void SetMappings()
        {
            BsonClassMap.RegisterClassMap<Candidate>(cm =>
            {
                cm.AutoMap();
                cm.IdMemberMap.SetSerializer(new StringSerializer(BsonType.ObjectId));
            });
        }
    }
}
