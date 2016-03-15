using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DiverseNote.Objects;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DiverseNote.Data
{
    public abstract class MongoRepository<T> where T : IEntity
    {
        protected readonly IMongoDatabase Database;
        protected string DatabaseName = DatabaseNames.DiverseNote;
        protected string DocumentCollectionName;

        protected MongoRepository()
        {
            var mongoClient = new MongoClient();
            Database = mongoClient.GetDatabase(DatabaseName);
        }

        public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> whereClause)
        {
           var results = await Database.GetCollection<T>(DocumentCollectionName).FindAsync(whereClause);
           return results.ToEnumerable();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> whereClause)
        {
            return Database.GetCollection<T>(DocumentCollectionName).Find(whereClause).ToEnumerable();
        }

        public virtual async Task<T> FindOneAsync(Expression<Func<T, bool>> whereClause)
        {
            var results = await Database.GetCollection<T>(DocumentCollectionName).FindAsync(whereClause);
            return results.FirstOrDefault();
        }

        public virtual async Task<string> InsertOneAsync(T document)
        {
            document.Id = ObjectId.GenerateNewId().ToString();
            var documents = Database.GetCollection<T>(DocumentCollectionName);
            await documents.InsertOneAsync(document);
            return document.Id;
        }

        public virtual async Task InsertManyAsync(IEnumerable<T> documents)
        {
            var recruiters = Database.GetCollection<T>(DocumentCollectionName);
            await recruiters.InsertManyAsync(documents);
        }

        public virtual async Task DeleteAsync(string id)
        {
            var documents = Database.GetCollection<T>(DocumentCollectionName);
            await documents.FindOneAndDeleteAsync(x => x.Id == id);
        }

        public virtual async Task UpdateAsync(T document)
        {
            var documents = Database.GetCollection<T>(DocumentCollectionName);
            await documents.ReplaceOneAsync(x => x.Id == document.Id, document);
        }

        protected abstract void SetMappings();

        protected abstract string GetCollectionTypeName();
    }
}
