using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteGH.Startup))]
namespace TesteGH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
