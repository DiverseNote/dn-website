using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DiverseNote.Objects;

namespace DiverseNote.Data.EntityRepositories.Interfaces
{
    public interface IAccountRepository
    {
        Task<IEnumerable<UserAccount>> FindAsync(Expression<Func<UserAccount, bool>> whereClause);
        IEnumerable<UserAccount> Find(Expression<Func<UserAccount, bool>> whereClause);
        IEnumerable<UserAccount> Find(Expression<Func<UserAccount, bool>> whereClause, int index, int size);
        Task<UserAccount> FindOneAsync(Expression<Func<UserAccount, bool>> whereClause);
        Task<string> InsertOneAsync(UserAccount document);
        Task InsertManyAsync(IEnumerable<UserAccount> documents);
        Task DeleteAsync(string id);
        Task UpdateAsync(UserAccount document);
    }
}