using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using StartupIdentity.Core.Domain.Entities;
using StartupIdentity.Core.Domain.Interfaces.Infrastructures.Data;
using System;

namespace StartupIdentity.Infrastructures.Data
{
    public class StartupIdentityDbContext : DbContext, IStartupIdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public StartupIdentityDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected StartupIdentityDbContext()
        {
        }
    }
}
