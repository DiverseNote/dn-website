using Algolia.Search;
using Autofac;
using DiverseNote.Data.EntityRepositories;
using DiverseNote.Data.EntityRepositories.Interfaces;
using DiverseNote.Data.Indexing.Mapping;

namespace DiverseNote.Data.Indexing.DependencyInjection
{
    public static class AutofacConfig
    {
        public static void RegisterTypes(ContainerBuilder container)
        {
            container.RegisterInstance(IndexTypeMapping.GetIndexTypeMapper());
            container.RegisterType<CandidateRepository>().As<ICandidateRepository>();
            container.RegisterType<RecruiterRepository>().As<IRecruiterRepository>();
            container.RegisterType<AlgoliaClient>().AsSelf();
        }
    }
}
