using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pac.Man.Startup))]
namespace Pac.Man
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
