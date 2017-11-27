using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DiverseNote.Objects;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using DiverseNote.Data.Extensions;
using MongoDB.Driver;
using DiverseNote.Data.EntityRepositories.Interfaces;

namespace DiverseNote.Data.EntityRepositories
{
    public sealed class AccountRepository : MongoRepository<UserAccount>, IAccountRepository
    {
        public AccountRepository()
        {
            DocumentCollectionName = GetCollectionTypeName();
            SetMappings();
        }

        public IEnumerable<UserAccount> Find(Expression<Func<UserAccount, bool>> whereClause, int pageNumber, int pageSize)
        {
            return Database.GetCollection<UserAccount>(DocumentCollectionName)
                .Find(whereClause).Skip(pageNumber > 0 ? ((pageNumber - 1) * pageSize) : 0)
                .Limit(pageSize).ToEnumerable();
        }
        
        protected override string GetCollectionTypeName()
        {
            return typeof(UserAccount).GetCollectionName();
        }

        protected override void SetMappings()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(UserAccount)))
                BsonClassMap.RegisterClassMap<UserAccount>(cm =>
                {
                    cm.SetIgnoreExtraElements(true);//TODO: Important - Remove before first production push
                    cm.AutoMap();
                    cm.IdMemberMap.SetSerializer(new StringSerializer(BsonType.ObjectId));
                });
        }
    }
}
