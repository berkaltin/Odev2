using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BerkWeb.Startup))]
namespace BerkWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
