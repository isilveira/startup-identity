using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace StartupIdentity.Middleware.IoC
{
    public static class Configurations
    {
        public static IServiceCollection AddStartupIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            // YOUR CODE GOES HERE
            return services;
        }

        public static IApplicationBuilder UseStartupIdentity(this IApplicationBuilder app)
        {
            // YOUR CODE GOES HERE
            return app;
        }
    }
}
