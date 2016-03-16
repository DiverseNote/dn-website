using System.Configuration;
using System.Threading.Tasks;
using Algolia.Search;
using AutoMapper;
using DiverseNote.Objects;
using DiverseNote.Objects.Index;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiverseNote.Data.Indexing.Indexers
{
    public class CandidateIndexProvider : ICandidateIndexProvider
    {
        private readonly IMapper _mapper;
        private readonly Index _index;
       
        public CandidateIndexProvider(IMapper mapper, AlgoliaClient algoliaClient)
        {
            _mapper = mapper;
            var candidateIndexName = ConfigurationManager.AppSettings.Get("CandidateIndexName");
            _index = algoliaClient.InitIndex(candidateIndexName);
        }

        public async Task UpsertCandidateIndex(Candidate candidate)
        {
            var indexCandidate = _mapper.Map<IndexCandidate>(candidate);
            var jObject = JObject.Parse(JsonConvert.SerializeObject(indexCandidate));
            await _index.SaveObjectAsync(jObject);
        }

        public async Task DeleteCandidateIndex(Candidate candidate)
        {
            await _index.DeleteObjectAsync(candidate.Id);
        }
    }
}
