using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SignalR;


namespace Websocket_server_with_SignalR
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.AddSignalR();
            services.AddLogging();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors(i =>
          {
              i.WithOrigins("null")
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();

          });

            app.UseRouting();

            /*
            app.UseSignalR() doesn't work anymore
            https://docs.microsoft.com/en-us/dotnet/core/compatibility/aspnet-core/5.0/signalr-usesignalr-useconnections-removed
            */



            app.UseEndpoints(r =>
            {
                r.MapHub<ChatHub>("/websckt");
                r.MapControllers();

            });
        }
    }
}
