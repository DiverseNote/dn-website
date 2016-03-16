using System.Threading.Tasks;
using DiverseNote.Objects;

namespace DiverseNote.Data.Indexing.Indexers
{
    public interface ICandidateIndexProvider
    {
        Task UpsertCandidateIndex(Candidate candidate);
        Task DeleteCandidateIndex(Candidate candidate);
    }
}