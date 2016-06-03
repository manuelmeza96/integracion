using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Integracion.Startup))]
namespace Integracion
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
