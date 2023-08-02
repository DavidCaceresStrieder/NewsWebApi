using NewsWebApi.Repository.Implementation;
using NewsWebApi.Repository.Interface;
using System.Runtime.CompilerServices;

namespace NewsWebApi.Repository
{
    public static class ServiceCollectionExtension
    {
        public static void AddNewsRepository(this IServiceCollection services)
        {
            services.AddTransient<INewsRepository,NewsRepository>();
        }
    }
}
