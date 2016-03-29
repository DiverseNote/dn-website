using System.Collections.Generic;
using Newtonsoft.Json;

namespace DiverseNote.Objects.Index
{
    [JsonObject("job")]
    public class IndexJob : IIndexEntity
    {
        [JsonProperty("objectID")]
        public string ObjectId => Id;

        public string Id { get; set; }

        public string Role { get; set; }

        [JsonProperty("_tags")]
        public IEnumerable<string> Tags { get; set; }
    }
}
