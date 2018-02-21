using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace HitCounter
{
    public class HitCounterHub : Hub
    {
        static int hitCount;

        public void Count()  
        {
            hitCount++;
            Clients.All.updateCount(hitCount);    
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            hitCount--;
            Clients.All.updateCount(hitCount);
            return base.OnDisconnected(stopCalled);
        }
    }
}