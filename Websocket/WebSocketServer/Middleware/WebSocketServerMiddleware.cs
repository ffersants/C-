using System;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace WebSocketServer.Middleware
{
    public class WebSocketServerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly WebSocketServerConnectionManager _manager;

        public WebSocketServerMiddleware(RequestDelegate next, WebSocketServerConnectionManager manager)
        {
            _next = next;
            _manager = manager;
        }

        public async Task SendConnIdAsync(string connID, WebSocket socket)
        {
            var buffer = Encoding.UTF8.GetBytes(connID);

            await socket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
        }

        public async Task ReceiveMessage(WebSocket webSocket, Action<WebSocketReceiveResult, byte[]> handleMessage)
        {
            var buffer = new byte[1024 * 4];

            while (webSocket.State == WebSocketState.Open)
            {
                var result = await webSocket.ReceiveAsync(buffer: new ArraySegment<byte>(buffer),
                cancellationToken: CancellationToken.None);

                handleMessage(result, buffer);
            }
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.WebSockets.IsWebSocketRequest)
            {

                //stablish the websocket connection
                WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();

                string ConnID = "teste";

                _manager.GetAllSockets().ToList().ForEach(async i =>
                {

                    if (i.Key == ConnID && i.Value.State == WebSocketState.Open)
                    {
                        await RemoveDuplicatedConnection(ConnID);
                    }
                });


                string connectionID = _manager.AddSocket(webSocket, ConnID);

                await SendConnIdAsync(connectionID, webSocket);

                Console.WriteLine("Websckt connected");

                await ReceiveMessage(webSocket, async (result, buffer) =>
                {
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        await RouteJSONMessageAsync(Encoding.UTF8.GetString(buffer, 0, result.Count));

                        Console.WriteLine("Mensagem recebida");
                        Console.WriteLine($"Message: {Encoding.UTF8.GetString(buffer, 0, result.Count)}");
                    }
                    else if (result.MessageType == WebSocketMessageType.Close)
                    {
                        string id = _manager.GetAllSockets().FirstOrDefault(i => i.Value == webSocket).Key;
                        if (id == null) return;
                        _manager.GetAllSockets().TryRemove(id, out WebSocket socket);

                        await socket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);

                        Console.WriteLine("Conexão fechada");
                    }
                });
            }
            else
            {
                //if it's not a websocket request, jump to handle the next request
                Console.WriteLine("It's not a request to be evaluated to websocket connectio.");
                await _next(context);
            }
        }

        public async Task RemoveDuplicatedConnection(string connId)
        {
            string id = _manager.GetAllSockets().FirstOrDefault(i => i.Key == connId).Key;

            _manager.GetAllSockets().TryRemove(id, out WebSocket webSocket);

            await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Identificada mais de uma conexão a partir do mesmo host", CancellationToken.None);

            //await socket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);

        }

        public async Task RouteJSONMessageAsync(string message)
        {
            var routeOb = JsonConvert.DeserializeObject<dynamic>(message);

            if (Guid.TryParse(routeOb.To.ToString(), out Guid targetSocketID))
            {
                var targetSocket = _manager.GetAllSockets().FirstOrDefault(i => i.Value.State == WebSocketState.Open && i.Key == targetSocketID.ToString());
                targetSocket.Value.SendAsync(Encoding.UTF8.GetBytes(routeOb.Message.ToString()), WebSocketMessageType.Text, true, CancellationToken.None);
            }
            else
            {
                Console.WriteLine("Broadcast");

                foreach (var socketConn in _manager.GetAllSockets())
                {
                    if (socketConn.Value.State == WebSocketState.Open)
                    {
                        await socketConn.Value.SendAsync(Encoding.UTF8.GetBytes(routeOb.Message.ToString()), WebSocketMessageType.Text, true, CancellationToken.None);
                    }
                }
            }
        }
    }
}