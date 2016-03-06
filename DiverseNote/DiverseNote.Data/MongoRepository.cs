using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DiverseNote.Data.Extensions;
using DiverseNote.Objects;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace DiverseNote.Data
{
    public class MongoRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly IMongoDatabase _database;
        protected string DatabaseName = DatabaseNames.DiverseNote;
        protected string DocumentCollectionName = typeof(T).GetCollectionName();

        public MongoRepository()
        {
            SetMappings();
            var mongoClient = new MongoClient();
            _database = mongoClient.GetDatabase(DatabaseName);
            
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> whereClause)
        {
           return await _database.GetCollection<T>(DocumentCollectionName).Find(whereClause).ToListAsync();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> whereClause)
        {
            return _database.GetCollection<T>(DocumentCollectionName).Find(whereClause).ToList();
        }

        public async Task<T> FindOneAsync(Expression<Func<T, bool>> whereClause)
        {
            return await _database.GetCollection<T>(DocumentCollectionName).Find(whereClause).FirstOrDefaultAsync();
        }

        public async Task<string> InsertOneAsync(T document)
        {
            document.Id = ObjectId.GenerateNewId().ToString();
            var documents = _database.GetCollection<T>(DocumentCollectionName);
            await documents.InsertOneAsync(document);
            return document.Id;
        }

        public async Task InsertManyAsync(IEnumerable<T> documents)
        {
            var recruiters = _database.GetCollection<T>(DocumentCollectionName);
            await recruiters.InsertManyAsync(documents);
        }

        public async Task DeleteAsync(string id)
        {
            var documents = _database.GetCollection<T>(DocumentCollectionName);
            await documents.FindOneAndDeleteAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Expression<Func<T, bool>> whereClause, T document)
        {
            var documents = _database.GetCollection<T>(DocumentCollectionName);
            await documents.ReplaceOneAsync(whereClause, document);
        }
        
        private void SetMappings()
        {
            BsonClassMap.RegisterClassMap<T>(cm =>
            {
                cm.AutoMap();
                cm.IdMemberMap.SetSerializer(new StringSerializer(BsonType.ObjectId));
            });
        }

    }
}
