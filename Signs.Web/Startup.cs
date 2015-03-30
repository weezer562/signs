using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Signs.Web.Startup))]
namespace Signs.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
