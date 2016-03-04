using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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
    }
}
