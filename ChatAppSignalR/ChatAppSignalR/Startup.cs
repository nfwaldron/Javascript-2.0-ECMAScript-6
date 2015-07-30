using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatAppSignalR.Startup))]
namespace ChatAppSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
