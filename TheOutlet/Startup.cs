using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheOutlet.Startup))]
namespace TheOutlet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
