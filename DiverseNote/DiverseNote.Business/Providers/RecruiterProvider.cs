using System;
using System.Collections.Generic;
using DiverseNote.Data.EntityRepositories.Interfaces;
using DiverseNote.Objects;

namespace DiverseNote.Business.Providers
{
    public class RecruiterProvider
    {
        private IRecruiterRepository _recruiterRepository;

        public RecruiterProvider(IRecruiterRepository recruiterRepository)
        {
            _recruiterRepository = recruiterRepository;
        }

        public void AddRecruiter(Recruiter recruiter)
        {
            throw new NotImplementedException();
        }

        public void UpdateRecruiter(Recruiter recruiter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recruiter> GetRecruiters(int startIndext, int count)
        {
            throw new NotImplementedException();
        }

        public Recruiter GetRecruiter(int recruiterId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecruiter(int recruiterId)
        {
            throw new NotImplementedException();
        }
    }
}
