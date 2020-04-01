using Microsoft.Extensions.DependencyInjection;
using WebAppClientes.Repositories;
using WebAppClientes.Services;

namespace WebAppClientes.Infra.CrossCutting.Ioc
{
    public class IocBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IClienteServices, ClienteServices>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
        }
    }
}