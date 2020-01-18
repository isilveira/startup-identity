using Microsoft.Extensions.DependencyInjection;
using System;

namespace StartupIdentity.Middleware.IoC
{
    public static class Configurations
    {
        public static IServiceCollection AddMiddleware(this IServiceCollection source)
        {
            return source;
        }
    }
}
