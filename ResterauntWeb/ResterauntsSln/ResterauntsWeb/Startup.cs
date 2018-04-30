using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResterauntsWeb.Startup))]
namespace ResterauntsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
