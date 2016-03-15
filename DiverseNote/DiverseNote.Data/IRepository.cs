using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DiverseNote.Objects;

namespace DiverseNote.Data
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> whereClause);

        IEnumerable<T> Find(Expression<Func<T, bool>> whereClause);

        Task<T> FindOneAsync(Expression<Func<T, bool>> whereClause);

        Task<string> InsertOneAsync(T document);

        Task InsertManyAsync(IEnumerable<T> documents);

        Task DeleteAsync(string id);

        Task UpdateAsync(T document);
    }
}