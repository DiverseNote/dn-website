using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DiverseNote.Objects;

namespace DiverseNote.Data
{
    public interface IDataContext<T> where T : IEntity
    {
        IEnumerable<T> FindMany(Expression<Func<T, bool>> whereClause);
        Task<string> InsertOne(T document);
        Task InsertMany(IEnumerable<T> documents);
        Task Delete(string id);
        Task Update(Expression<Func<T, bool>> whereClause, T document);
    }
}