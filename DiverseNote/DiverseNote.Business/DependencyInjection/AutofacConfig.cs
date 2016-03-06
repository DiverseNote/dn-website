using Autofac;
using DiverseNote.Data;
using DiverseNote.Objects;

namespace DiverseNote.Business.DependencyInjection
{
    public static class AutofacConfig
    {
        public static void RegisterTypes()
        {
            var container = new ContainerBuilder();

            container.RegisterType<MongoRepository<Recruiter>>().As<IRepository<Recruiter>>();
            container.RegisterType<MongoRepository<Candidate>>().As<IRepository<Candidate>>();
            container.RegisterType<MongoRepository<Skill>>().As<IRepository<Skill>>();
            container.RegisterType<MongoRepository<Job>>().As<IRepository<Job>>();
            container.RegisterType<MongoRepository<Organization>>().As<IRepository<Organization>>();

            container.Build();
        }
    }
}
