using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace DiverseNote.Objects
{    
    public class Candidate : IEntity
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }

        public Gender Gender { get; set; }

        public bool IsDisabled { get; set; }

        public bool IsVeteran { get; set; }

        public bool IsLgbtq { get; set; }
        
        public IEnumerable<Skill> Skills { get; set; }

        public ExperienceLevel? ExperienceLevel { get; set; }

        public IEnumerable<Experience> Experiences { get; set; }

        public IEnumerable<School> Schools { get; set; }

        public IEnumerable<EthnicityTypes> EthnicityTypes { get; set; }

        public IEnumerable<string> GeographicTargets { get; set; }

        public IEnumerable<string> InterestedInRoles { get; set; }
       
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
