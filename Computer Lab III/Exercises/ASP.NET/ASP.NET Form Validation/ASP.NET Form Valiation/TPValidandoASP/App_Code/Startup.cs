using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPValidandoASP.Startup))]
namespace TPValidandoASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
