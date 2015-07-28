using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prototype_Inheritance.Startup))]
namespace Prototype_Inheritance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
