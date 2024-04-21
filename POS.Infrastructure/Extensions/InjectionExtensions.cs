using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infrastructure.Persistences.Contexts;

namespace POS.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(SisventasContext).Assembly.FullName;

            services.AddDbContext<SisventasContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"), b => b.MigrationsAssembly(assembly)),
                ServiceLifetime.Transient
            );

            return services;
        }
    }
}
