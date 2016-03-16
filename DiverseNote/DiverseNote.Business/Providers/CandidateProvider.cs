using System.Threading.Tasks;
using DiverseNote.Business.Interfaces;
using DiverseNote.Data.EntityRepositories.Interfaces;
using DiverseNote.Objects;
using DiverseNote.Data.Indexing.Indexers;

namespace DiverseNote.Business.Providers
{
    public class CandidateProvider : ICandidateProvider
    {
        private readonly ICandidateRepository _candidateRepository;
        

        public CandidateProvider(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<string> AddCandidateAsync(Candidate candidate, UserInfo userInfo)
        {
            return await _candidateRepository.InsertOneAsync(candidate);
        }

        public async Task<Candidate> GetCandidateAsync(string candidateId, UserInfo userInfo)
        {
            return await _candidateRepository.FindOneAsync(x => x.Id == candidateId);
        }

        public async Task UpdateCandidateAsync(Candidate candidate, UserInfo userInfo)
        {
            await _candidateRepository.UpdateAsync(candidate);
        }

        public async Task DeleteCandidateAsync(string id, UserInfo userInfo)
        {
            var candidate = await _candidateRepository.FindOneAsync(x => x.Id == id);
            candidate.IsDeleted = true;
            await _candidateRepository.UpdateAsync(candidate);
            
        }
    }
}
