using Algolia.Search;

namespace DiverseNote.IndexService.Indexers
{
    public interface ICandidateIndexer
    {
        void Index(AlgoliaClient client);
        void SetRankings(AlgoliaClient client);
    }
}