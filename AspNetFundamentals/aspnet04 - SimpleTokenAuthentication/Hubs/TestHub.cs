using Microsoft.AspNet.SignalR;
using System;
using System.Linq;
using System.Security.Claims;

namespace SimpleTokenAuthentication.Hubs
{
    [Authorize]
    public class TestHub : Hub
    {
        public void Hello()
        {
            var userName = (Context.User.Identity as ClaimsIdentity).Claims.FirstOrDefault(claim => claim.Type == "UserName").Value;
            Clients.All.hello(String.Format("You are authorized, {0} !", userName));
        }
    }
}