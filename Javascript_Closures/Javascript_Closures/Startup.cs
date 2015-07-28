using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Javascript_Closures.Startup))]
namespace Javascript_Closures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
