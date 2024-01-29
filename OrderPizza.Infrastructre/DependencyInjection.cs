using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderPizza.Infrastructre.Persistence;

namespace OrderPizza.Infrastructre
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructre(this IServiceCollection services,
                    IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
