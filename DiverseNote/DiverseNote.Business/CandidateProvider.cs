using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiverseNote.Objects;
using DiverseNote.Objects.SearchCriteria;
using DiverseNote.Data;

namespace DiverseNote.Business
{
    public class CandidateProvider
    {
        private readonly IRepository<Candidate> _candidateRepository;

        public CandidateProvider(IRepository<Candidate> candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<string> AddCandidate(Candidate candidate, UserInfo userInfo)
        {
            return await _candidateRepository.InsertOneAsync(candidate);
        }

        public async Task<Candidate> GetCandidate(string candidateId, UserInfo userInfo)
        {
            return await _candidateRepository.FindOneAsync(x => x.Id == candidateId);
        }

        public async Task<IEnumerable<Candidate>> GetCandidates(CandidateCriteria candidateCriteria, UserInfo userInfo)
        {
            //TODO: pagination.  all candidates will be too large.
            return await _candidateRepository.FindAsync(x => x.IsActive);
        }

        public void UpdateCandidate(Candidate candidate)
        {
            throw new NotImplementedException();
        }        
    }
}
