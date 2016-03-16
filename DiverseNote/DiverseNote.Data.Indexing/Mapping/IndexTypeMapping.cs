using AutoMapper;
using DiverseNote.Objects;
using DiverseNote.Objects.Index;

namespace DiverseNote.Data.Indexing.Mapping
{
    public static class IndexTypeMapping
    {
        public static IMapper GetIndexTypeMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Candidate, IndexCandidate>();
                cfg.CreateMap<Job, IndexJob>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}
