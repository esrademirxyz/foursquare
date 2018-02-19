using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoursquareApp.Startup))]
namespace FoursquareApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
