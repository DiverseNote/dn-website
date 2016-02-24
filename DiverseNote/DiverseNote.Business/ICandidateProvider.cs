using DiverseNote.Objects;
using DiverseNote.Objects.SearchCriteria;
using System.Collections.Generic;

namespace DiverseNote.Business
{
    public interface ICandidateProvider
    {
        int AddCandidate(Candidate candidate, UserInfo userInfo);

        Candidate GetCandidate(int candidateId, UserInfo userInfo);

        IEnumerable<Candidate> GetCandidates(CandidateCriteria candidateCriteria, UserInfo userInfo);

        void UpdateCandidate(Candidate candidate);
    }
}