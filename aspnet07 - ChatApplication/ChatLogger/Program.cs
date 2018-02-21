using Microsoft.AspNet.SignalR.Client;
using System;

namespace ChatLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var hubConnection = new HubConnection("http://localhost:8080");
            var hub = hubConnection.CreateHubProxy("ChatHub");

            hub.On<string, string>("messageReceived", (originatorUser, message) => Console.WriteLine("{0}:   {1}\n", originatorUser, message));

            hubConnection.Start().Wait();

            Console.ReadLine();
        }
    }
}
