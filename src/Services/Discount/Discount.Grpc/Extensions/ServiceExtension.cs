using AutoMapper;
using Discount.Grpc.Mappings;

namespace Discount.Grpc.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureMapping(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(map =>
            {
                map.AddProfile<DiscountMappingProfile>();
            });
            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
