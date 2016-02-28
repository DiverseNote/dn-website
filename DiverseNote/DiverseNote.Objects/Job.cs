using System.Collections.Generic;

namespace DiverseNote.Objects
{
    public class Job
    {
        public int JobId { get; set; }
        public int OrganizationId { get; set; }
        public string JobTitle { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}