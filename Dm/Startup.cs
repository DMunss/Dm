using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dm.Startup))]
namespace Dm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
