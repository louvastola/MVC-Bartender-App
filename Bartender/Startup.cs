using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bartender.Startup))]
namespace Bartender
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
