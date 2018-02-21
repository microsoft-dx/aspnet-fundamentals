using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BasicHitCounter.Startup))]

namespace BasicHitCounter
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
