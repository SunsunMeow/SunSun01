using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunSun.Web.Startup))]
namespace SunSun.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
