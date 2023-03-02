using ecommerce.Application.Contracts;
using ecommerce.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ecommerce.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddScoped(typeof(IAuthRepository), typeof(AuthRepository));
            services.AddScoped(typeof(ICustomerRepository), typeof(CustomerRepository));


            return services;
        }
    }
}
