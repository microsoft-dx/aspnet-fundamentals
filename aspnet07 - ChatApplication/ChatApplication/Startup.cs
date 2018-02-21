using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ChatApplication.Startup))]

namespace ChatApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(new HubConfiguration
            {
                EnableDetailedErrors = true
            });
        }
    }
}
