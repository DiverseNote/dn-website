using System;
using System.Collections.Generic;

namespace DiverseNote.Objects
{
    public class Job : IEntity
    {
        public string Id { get; set; }
        public int OrganizationId { get; set; }
        public string JobTitle { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}