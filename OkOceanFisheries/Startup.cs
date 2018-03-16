using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OkOceanFisheries.Startup))]
namespace OkOceanFisheries
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
