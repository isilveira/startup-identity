using Microsoft.EntityFrameworkCore;
using StartupIdentity.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartupIdentity.Core.Domain.Interfaces.Infrastructures.Contexts
{
    public interface IStartupIdentityDbContext
    {
        DbSet<Role> Roles { get; set; }
        DbSet<RoleClaim> RoleClaims { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserClaim> UserClaims { get; set; }
        DbSet<UserLogin> UserLogins { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<UserToken> UserTokens { get; set; }
    }
}
