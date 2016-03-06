using System;
using System.Collections.Generic;
using Algolia.Search;
using DiverseNote.Objects;
using DiverseNote.Data;
using System.Configuration;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiverseNote.IndexService.Indexers
{
    public class CandidateIndexer : ICandidateIndexer
    {
        private readonly IRepository<Candidate> _candidateRepository;
        private readonly int _uploadSize = 1000;
        private readonly string _candidateIndexName;
       
        public CandidateIndexer()
        {
            _candidateRepository = new MongoRepository<Candidate>();
            _candidateIndexName = ConfigurationManager.AppSettings.Get("CandidateIndexName");
        }

        public void Index(AlgoliaClient client)
        {
            var index = client.InitIndex(_candidateIndexName);

            var indexCandidates = GetIndexSet(0, _uploadSize).ToList();
            if (indexCandidates.Any())
                index.SaveObjects(indexCandidates);
        }

        private IEnumerable<JObject> GetIndexSet(int index, int size)
        {
            var results = _candidateRepository.Find(x => x.IsActive).Skip(index).Take(size);
            return results.Select(x =>
            {
                var id = x.Id;
                var jObject = JObject.Parse(JsonConvert.SerializeObject(x));
                jObject.Add("objectID", id);
                return jObject;
            });
        }
    }
}
