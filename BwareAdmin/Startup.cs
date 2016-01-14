using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BwareAdmin.Startup))]
namespace BwareAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
