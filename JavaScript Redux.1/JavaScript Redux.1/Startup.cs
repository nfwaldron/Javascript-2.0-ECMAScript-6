using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JavaScript_Redux._1.Startup))]
namespace JavaScript_Redux._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
