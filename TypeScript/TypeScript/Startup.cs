using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TypeScript.Startup))]
namespace TypeScript
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
