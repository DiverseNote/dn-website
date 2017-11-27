using System;
using System.Collections.Generic;

namespace DiverseNote.Objects
{
    public class Recruiter : IEntity
    {
        public string Id { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int RecruiterId { get; set; }

        public int OrganizationId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<Search> Searches { get; set; }
    }
}
