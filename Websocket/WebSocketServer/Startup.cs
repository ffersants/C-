using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net.WebSockets;
using Microsoft.VisualBasic;
using System.Threading;
using Microsoft.AspNetCore.Authentication;

namespace WebSocketServer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseWebSockets();
            
            app.Use(async (context, next) => {
                //PrintRequestData(context);

                if(context.WebSockets.IsWebSocketRequest)
                {
                    //stablish the websocket connection
                    WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
                    Console.WriteLine("Websckt connected");
                
                    await ReceiveMessage(webSocket, async (result, buffer) => {
                        if(result.MessageType  == WebSocketMessageType.Text){
                            System.Console.WriteLine("Mensagem recebida");
                        }
                        else if (result.MessageType == WebSocketMessageType.Close){
                            System.Console.WriteLine("Conexão fechada");
                        }
                    });
                }
                else {
                    //if it's not a websocket request, jump to handle the next request
                    Console.WriteLine("It's not a request to be evaluated to websocket connectio.");
                    await next();
                }
            });

            app.Run(async (context) => {
                await context.Response.WriteAsync("Return message");
            });
        }

        public async Task ReceiveMessage(WebSocket webSocket, Action<WebSocketReceiveResult, byte[]> handleMessage){
            var buffer = new byte[1024 * 4 ];

            while(webSocket.State == WebSocketState.Open){
                var result = await webSocket.ReceiveAsync(buffer: new ArraySegment<byte>(buffer),
                cancellationToken: CancellationToken.None);

                handleMessage(result, buffer);
            }
        }

        public void PrintRequestData(HttpContext context){
            System.Console.WriteLine(context.Request.Method);
            System.Console.WriteLine(context.Request.Protocol);
           
            if(context.Request.Headers != null){
                /*
                    websocket request have these headers with its following values
                    Upgrade---->websocket
                    Connection---->Upgrade
                    Sec-WebSocket-Version---->13
                    Sec-WebSocket-Key---->7GZYyC4LICy8er7yzN0d/g==
                    Sec-WebSocket-Extensions---->permessage-deflate; client_max_window_bits
                */
                foreach(var h in context.Request.Headers){
                    System.Console.WriteLine(h.Key + "---->" + h.Value);
                }
            }
        }
    }
}
