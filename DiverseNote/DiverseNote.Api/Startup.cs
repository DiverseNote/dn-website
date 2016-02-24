using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DiverseNote.Api.Startup))]

namespace DiverseNote.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
