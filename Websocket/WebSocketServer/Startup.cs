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
using WebSocketServer.Middleware;

namespace WebSocketServer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.UseWebSocketManager();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseWebSockets();
            
            app.UseWebSocketServer();

            app.Run(async (context) => {
                await context.Response.WriteAsync("Return message");
            });
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
