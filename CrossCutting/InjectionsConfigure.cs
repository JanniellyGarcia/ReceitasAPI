using Data.Repositories;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;
using Service.Service;

namespace CrossCutting
{
    public static class InjectionsConfigure
    {
        public static void AddDependencyInjectionConfig(this IServiceCollection services)
        {
            //baseEntity
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            //Recipe
            services.AddScoped(typeof(IRecipesRepository), typeof(RecipeRepository));
            services.AddScoped(typeof(IRecipeService), typeof(RecipeService));
        }
    }
}