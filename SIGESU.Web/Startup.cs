using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIGESU.Web.Startup))]
namespace SIGESU.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
