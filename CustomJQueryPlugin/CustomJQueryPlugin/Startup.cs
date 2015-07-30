using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomJQueryPlugin.Startup))]
namespace CustomJQueryPlugin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
