using Autofac;
using DiverseNote.Business.Interfaces;
using DiverseNote.Business.Providers;

namespace DiverseNote.Business.DependencyInjection
{
    public static class AutofacConfig
    {
        public static void RegisterTypes(ContainerBuilder container)
        {
            Data.Indexing.DependencyInjection.AutofacConfig.RegisterTypes(container); 
            container.RegisterType<CandidateProvider>().As<ICandidateProvider>();            
        }
    }
}
