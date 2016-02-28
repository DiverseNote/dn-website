using System;
using System.Collections.Generic;
using DiverseNote.Objects;
using DiverseNote.Objects.SearchCriteria;

namespace DiverseNote.Business
{
    public class CandidateProvider
    {
        public int AddCandidate(Candidate candidate, UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public Candidate GetCandidate(int candidateId, UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Candidate> GetCandidates(CandidateCriteria candidateCriteria, UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public void UpdateCandidate(Candidate candidate)
        {
            throw new NotImplementedException();
        }        
    }
}
