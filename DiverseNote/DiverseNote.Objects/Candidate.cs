using System;
using System.Collections.Generic;

namespace DiverseNote.Objects
{
    public class Candidate : IEntity
    {
        public string Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }
        
        public IEnumerable<Skill> Skills { get; set; }

        public IEnumerable<Experience> Experiences { get; set; }

        public IEnumerable<College> Educations { get; set; }

        public IEnumerable<DiversityTypes> DiversityTypes { get; set; }

        public IEnumerable<string> InterestedInLocations { get; set; }

        public IEnumerable<string> InterestedInRoles { get; set; }
        
        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime ModifiedDate { get; set; }

        //for deletion
        public int CandidateId { get; set; }
    }
}
