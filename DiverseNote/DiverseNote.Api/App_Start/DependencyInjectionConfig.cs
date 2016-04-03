using Autofac.Integration.WebApi;
using Autofac;
using System.Web.Http;
using System.Reflection;
using DiverseNote.Business.DependencyInjection;

namespace DiverseNote.Api.App_Start
{
    public static class DependencyInjectionConfig
    {
        public static void Initialize(HttpConfiguration config)
        {
            var containerBuilder = new ContainerBuilder();
            AutofacConfig.RegisterTypes(containerBuilder);
            Initialize(config, RegisterServices(containerBuilder, config));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {            
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder, HttpConfiguration config)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);
            return builder.Build();
        }
    }
}