using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HitCounter.Startup))]

namespace HitCounter
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
