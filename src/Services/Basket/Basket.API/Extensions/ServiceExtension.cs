using Basket.API.GrpcServices;
using Basket.API.Repositories.Interfaces;
using Basket.API.Repositories.Services;
using Discount.Grpc.Protos;

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

            services.AddGrpcClient<DiscountProtoService.DiscountProtoServiceClient>(
                options => options.Address = new Uri(configuration["GrpcSettings:DiscountUrl"]));

            services.AddScoped<DiscountGrpcService>();
        }
    }
}
