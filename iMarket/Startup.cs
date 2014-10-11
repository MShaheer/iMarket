using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iMarket.Startup))]
namespace iMarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
