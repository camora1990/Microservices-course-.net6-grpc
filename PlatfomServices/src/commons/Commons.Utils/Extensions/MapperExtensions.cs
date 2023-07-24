using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Commons.Utils.MapperExtensions
{
    public static class MapperExtensions
    {
        public static IServiceCollection AddMapperServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapExtensions));
            return services;
        }
    }
}