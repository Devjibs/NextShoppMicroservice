using Basket.API.Repositories.Interfaces;
using Basket.API.Repositories.Services;

namespace Basket.API.Extensions
{
    public static class ServiceExtension
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString");
            });
            services.AddScoped<IBasketRepository, BasketRepository>();
        }
    }
}
