﻿using Autofac;
using DiverseNote.Data.EntityRepositories;
using DiverseNote.Data.EntityRepositories.Interfaces;

namespace DiverseNote.Business.DependencyInjection
{
    public static class AutofacConfig
    {
        public static IContainer RegisterTypes()
        {
            Data.Indexing.DependencyInjection.AutofacConfig.RegisterTypes();

            var container = new ContainerBuilder();
            container.RegisterType<RecruiterRepository>().As<IRecruiterRepository>();
            container.RegisterType<CandidateRepository>().As<ICandidateRepository>();

            return container.Build();
        }
    }
}
