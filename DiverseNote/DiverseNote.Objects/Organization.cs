using System;
using System.Collections.Generic;

namespace DiverseNote.Objects
{
    public class Organization : IEntity
    {
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public byte[] Logo { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public DateTime ModifiedDate { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerator<Search> Searches { get; set; }
    }
}
