using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace StartupIdentity.Middleware.IoC
{
    public static class Configurations
    {
        public static IServiceCollection AddStartupIdentity(this IServiceCollection services)
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
