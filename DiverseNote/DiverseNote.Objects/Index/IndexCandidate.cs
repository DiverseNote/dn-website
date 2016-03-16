using System.Collections.Generic;
using Newtonsoft.Json;

namespace DiverseNote.Objects.Index
{
    [JsonObject("candidate")]
    public class IndexCandidate : IIndexEntity
    {
        [JsonProperty("objectID")]
        public string ObjectId => Id;

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }

        public IEnumerable<Skill> Skills { get; set; }

        public IEnumerable<Experience> Experiences { get; set; }

        public IEnumerable<College> Educations { get; set; }
    }
}
