using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPWebFormASP.Startup))]
namespace TPWebFormASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
