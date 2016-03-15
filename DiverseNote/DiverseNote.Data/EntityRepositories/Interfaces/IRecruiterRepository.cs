using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DiverseNote.Objects;

namespace DiverseNote.Data.EntityRepositories.Interfaces
{
    public interface IRecruiterRepository
    {
        Task<IEnumerable<Recruiter>> FindAsync(Expression<Func<Recruiter, bool>> whereClause);
        IEnumerable<Recruiter> Find(Expression<Func<Recruiter, bool>> whereClause);
        Task<Recruiter> FindOneAsync(Expression<Func<Recruiter, bool>> whereClause);
        Task<string> InsertOneAsync(Recruiter document);
        Task InsertManyAsync(IEnumerable<Recruiter> documents);
        Task DeleteAsync(string id);
        Task UpdateAsync(Recruiter document);
    }
}