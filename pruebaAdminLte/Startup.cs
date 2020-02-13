using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebaAdminLte.Startup))]
namespace pruebaAdminLte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
