using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InformationApp.Startup))]
namespace InformationApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
