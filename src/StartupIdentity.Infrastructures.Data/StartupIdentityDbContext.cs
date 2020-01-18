using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;

namespace StartupIdentity.Infrastructures.Data
{
    public class StartupIdentityDbContext : DbContext
    {
        public StartupIdentityDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected StartupIdentityDbContext()
        {
        }
    }
}
