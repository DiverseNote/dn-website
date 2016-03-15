using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DiverseNote.Objects;

namespace DiverseNote.Data.EntityRepositories.Interfaces
{
    public interface ICandidateRepository
    {
        Task<IEnumerable<Candidate>> FindAsync(Expression<Func<Candidate, bool>> whereClause);
        IEnumerable<Candidate> Find(Expression<Func<Candidate, bool>> whereClause);
        IEnumerable<Candidate> Find(Expression<Func<Candidate, bool>> whereClause, int index, int size);
        Task<Candidate> FindOneAsync(Expression<Func<Candidate, bool>> whereClause);
        Task<string> InsertOneAsync(Candidate document);
        Task InsertManyAsync(IEnumerable<Candidate> documents);
        Task DeleteAsync(string id);
        Task UpdateAsync(Candidate document);
    }
}