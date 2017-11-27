using System.Threading.Tasks;
using DiverseNote.Objects;

namespace DiverseNote.Business.Interfaces
{
    public interface ICandidateProvider
    {
        Task<string> AddCandidateAsync(Candidate candidate, UserAccount userInfo);
        Task<Candidate> GetCandidateAsync(string candidateId, UserAccount userInfo);
        Task UpdateCandidateAsync(Candidate candidate, UserAccount userInfo);
        Task DeleteCandidateAsync(string id, UserAccount userInfo);
    }
}