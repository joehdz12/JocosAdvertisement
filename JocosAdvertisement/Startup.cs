using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JocosAdvertisement.Startup))]
namespace JocosAdvertisement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
