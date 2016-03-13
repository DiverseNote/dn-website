using Autofac;
using DiverseNote.Data.EntityRepositories;
using DiverseNote.Data.EntityRepositories.Interfaces;

namespace DiverseNote.Business.DependencyInjection
{
    public static class AutofacConfig
    {
        public static void RegisterTypes()
        {
            var container = new ContainerBuilder();
            container.RegisterType<RecruiterRepository>().As<IRecruiterRepository>();
            container.RegisterType<CandidateRepository>().As<ICandidateRepository>();

            container.Build();
        }
    }
}
