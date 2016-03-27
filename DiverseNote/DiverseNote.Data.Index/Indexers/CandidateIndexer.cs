using System;
using System.Collections.Generic;
using Algolia.Search;
using DiverseNote.Data.EntityRepositories.Interfaces;
using System.Configuration;
using System.Linq;
using DiverseNote.Data.EntityRepositories;
using DiverseNote.IndexService.ConversionExtensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiverseNote.IndexService.Indexers
{
    public class CandidateIndexer : ICandidateIndexer
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly int _uploadSize;
        private readonly string _candidateIndexName;
        private readonly int _maxDescriptionSize = 300;
       
        public CandidateIndexer()
        {
            _candidateRepository = new CandidateRepository();
            _candidateIndexName = ConfigurationManager.AppSettings.Get("CandidateIndexName");
            int.TryParse(ConfigurationManager.AppSettings.Get("UploadSize"), out _uploadSize);
        }

        public void Index(AlgoliaClient client)
        {
            var index = client.InitIndex(_candidateIndexName);
            var moreRecords = true;
            var page = 1;

            while (moreRecords)
            {
                var indexCandidates = GetIndexSet(page, _uploadSize).ToList();
                if (indexCandidates.Any())
                {
                    index.SaveObjects(indexCandidates);
                    page++;
                }
                else
                {
                    moreRecords = false;
                }
            }
        }

        private IEnumerable<JObject> GetIndexSet(int page, int size)
        {
            var results = _candidateRepository.Find(x => !x.IsDeleted, page, size);
            return results.Select(x =>
            {
                var indexCandidate = x.GetIndexCandidate();
                indexCandidate.FirstName = indexCandidate.FirstName.Substring(0, 1);
                indexCandidate.LastName = indexCandidate.LastName.Substring(0, 1);

                if (indexCandidate.Description?.Length > _maxDescriptionSize)
                    indexCandidate.Description = indexCandidate.Description?.Substring(0, _maxDescriptionSize) + "...";

                var jObject = JObject.Parse(JsonConvert.SerializeObject(indexCandidate));
                return jObject;
            });
        }

        public void SetRankings(AlgoliaClient client)
        {
            var index = client.InitIndex(_candidateIndexName);
            index.SetSettings(JObject.Parse(@"{""attributesToIndex"":
               [""Skills"",
                ""Description"", 
                ""InterestedInLocations"",
                ""InterestedInRoles""
                ]}"));
        }
    }
}
