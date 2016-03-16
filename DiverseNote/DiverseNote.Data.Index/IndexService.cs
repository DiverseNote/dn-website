using System.Configuration;
using Algolia.Search;
using DiverseNote.IndexService.Indexers;

namespace DiverseNote.IndexService
{
    public class IndexService
    {
        private readonly string _algoliaAppId;
        private readonly string _algoliaApiKey;
        private readonly ICandidateIndexer _candidateIndexer;

        public IndexService()
        {
            _algoliaAppId = ConfigurationManager.AppSettings.Get("AlgoliaAppId");
            _algoliaApiKey = ConfigurationManager.AppSettings.Get("AlgoliaApiKey");
            _candidateIndexer = new CandidateIndexer();
        }

        public void Start()
        {
            var client = new AlgoliaClient(_algoliaAppId, _algoliaApiKey);
            _candidateIndexer.SetRankings(client);
            _candidateIndexer.Index(client);
        }

        public void Stop()
        {
        }
    }
}
