using API.Domain.Interfaces.Services.Users;
using API.Service.Services;
using Domain.Interfaces.Services.Users;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace API.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}
