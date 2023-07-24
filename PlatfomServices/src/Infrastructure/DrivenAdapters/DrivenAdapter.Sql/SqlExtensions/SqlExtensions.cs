using Domain.Model.Repositories;
using DrivenAdapter.Sql.Adapters;
using DrivenAdapter.Sql.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DrivenAdapter.Sql.SqlExtensions
{
    public static class SqlExtensions
    {
        public static IServiceCollection AddDatabaseServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<PlatformContext>(options => options.UseSqlServer(connectionString));
            return services;
        }

        public static IServiceCollection AddRepositoriesServices(this IServiceCollection services)
        {
            services.AddTransient<IPlatformRespository, PlatformAdapter>();
            return services;
        }
    }
}