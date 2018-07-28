using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(moviesWebSite.Startup))]
namespace moviesWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
