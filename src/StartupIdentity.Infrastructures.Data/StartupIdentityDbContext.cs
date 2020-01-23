using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StartupIdentity.Core.Domain.Entities;
using StartupIdentity.Core.Domain.Interfaces.Infrastructures.Contexts;

namespace StartupIdentity.Infrastructures.Data
{
    public class StartupIdentityDbContext : IdentityDbContext<User, Role, string, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>, IStartupIdentityDbContext
    {
        public StartupIdentityDbContext()
        {
        }

        public StartupIdentityDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
