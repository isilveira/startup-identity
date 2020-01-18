using Microsoft.EntityFrameworkCore;
using StartupIdentity.Core.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace StartupIdentity.Core.Domain.Interfaces.Infrastructures.Data
{
    public interface IStartupIdentityDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
