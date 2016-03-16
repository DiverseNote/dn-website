using Algolia.Search;
using Autofac;
using DiverseNote.Data.EntityRepositories;
using DiverseNote.Data.EntityRepositories.Interfaces;
using DiverseNote.Data.Indexing.Mapping;

namespace DiverseNote.Data.Indexing.DependencyInjection
{
    public static class AutofacConfig
    {
        public static IContainer RegisterTypes()
        {
            var container = new ContainerBuilder();
            container.RegisterInstance(IndexTypeMapping.GetIndexTypeMapper());
            container.RegisterType<CandidateRepository>().As<ICandidateRepository>();
            container.RegisterType<AlgoliaClient>().AsSelf();
            return container.Build();
        }
    }
}
