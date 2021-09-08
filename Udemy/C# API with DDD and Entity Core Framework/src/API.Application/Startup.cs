using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.CrossCutting.DependencyInjection;
using API.Data.Context;
using Domain.Security;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyContext>(
                options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=opae1256")
            );

            ConfigureService.ConfigureDependenciesService(services);
            ConfigureRepository.ConfigureDependenciesRepository(services);

            //started - configuração da autenticação
            var signingConfigurations = new SigningConfigurations();
            services.AddSingleton(signingConfigurations);

            //configura as propriedades da classe tokenConfigurations com os valores
            //decalarados no appsettings.json
            var tokenConfigurations = new TokenConfiguration();
            new ConfigureFromConfigurationOptions<TokenConfiguration>
                (
                    //acessa o appsettings.json
                    Configuration.GetSection("TokenConfigurations")
                )
                //pega os valores da seção TokenConfigurations e configura a classe
                .Configure(tokenConfigurations);

            services.AddSingleton(tokenConfigurations);
            //finished - configurãção da autenticação

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "application", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "application v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
