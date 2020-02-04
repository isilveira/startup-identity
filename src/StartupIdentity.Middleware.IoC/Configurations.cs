using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StartupIdentity.Core.Domain.Entities;
using StartupIdentity.Infrastructures.Data;

namespace StartupIdentity.Middleware.IoC
{
    public static class Configurations
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
        {
            services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<Role>()
                .AddEntityFrameworkStores<StartupIdentityDbContext>();

            return services;
        }
        public static IServiceCollection AddStartupIdentityDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StartupIdentityDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            return services;
        }

        public static IServiceCollection AddStartupIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            // YOUR CODE GOES HERE
            return services;
        }

        public static IApplicationBuilder UseStartupIdentity(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();
            // YOUR CODE GOES HERE
            return app;
        }
    }
}
