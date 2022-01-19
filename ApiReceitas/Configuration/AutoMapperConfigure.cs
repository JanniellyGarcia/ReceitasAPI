using Microsoft.Extensions.DependencyInjection;
using Service.AutoMapper;
using System.Reflection;


namespace ApiReceitas.Configuration
{
    public static class AutoMapperConfigure
    {
        public static void AddAutoMapperConfig(this IServiceCollection services)
           => services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapperProfile)));

    }
}
