using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MapLocator.Startup))]

namespace MapLocator
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
