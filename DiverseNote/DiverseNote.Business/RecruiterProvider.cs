using System;
using System.Collections.Generic;
using DiverseNote.Objects;
using DiverseNote.Data;

namespace DiverseNote.Business
{
    public class RecruiterProvider
    {
        private IRepository<Recruiter> _recruiterContext;

        public RecruiterProvider(IRepository<Recruiter> recruiterContext)
        {
            _recruiterContext = recruiterContext;
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
