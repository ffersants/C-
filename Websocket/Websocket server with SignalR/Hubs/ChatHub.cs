using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Websocket_server_with_SignalR{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {   
            System.Console.WriteLine("Connected ->" + Context.ConnectionId);
            Clients.Client(Context.ConnectionId).SendAsync("ReceiveConnID", Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public async Task SendMessage(string message){
            var messageObj = JsonConvert.DeserializeObject<dynamic>(message);

            string messageDestination = messageObj?.To; 

            if(String.IsNullOrEmpty(messageDestination)){
                await Clients.All.SendAsync("ReceiveMessage", message);
            }
            else {
                await Clients.Client(messageDestination).SendAsync("ReceiveMessage", message);
            }

        }
    }
}