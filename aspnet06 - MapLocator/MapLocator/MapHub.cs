using Microsoft.AspNet.SignalR;

namespace MapLocator
{
    public class MapHub : Hub
    {
        public void PlaceMarker(string latitude, string longitude)
        {
            Clients.All.placeMarker(latitude, longitude);
        }
    }
}