using Microsoft.AspNet.SignalR.Client;
using System;

namespace ConsoleMapLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var hubConnection = new HubConnection("http://localhost:2186/");
            var hub = hubConnection.CreateHubProxy("MapHub");

            hub.On<string, string>("placeMarker", (latitude, longitude) => Console.WriteLine("Latitude: {0} \nLongitude: {1}\n", latitude, longitude));

            hubConnection.Start().Wait();

            Console.ReadLine();
        }
    }
}
