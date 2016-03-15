using System.Threading.Tasks;
using DiverseNote.Objects;

namespace DiverseNote.Business.Interfaces
{
    public interface ICandidateProvider
    {
        Task<string> AddCandidateAsync(Candidate candidate, UserInfo userInfo);
        Task<Candidate> GetCandidateAsync(string candidateId, UserInfo userInfo);
        Task UpdateCandidateAsync(Candidate candidate, UserInfo userInfo);
        Task DeleteCandidateAsync(string id, UserInfo userInfo);
    }
}