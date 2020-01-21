using Microsoft.AspNetCore.Identity;

namespace StartupIdentity.Core.Domain.Entities
{
    public class RoleClaim : IdentityRoleClaim<string>
    {
        public RoleClaim() : base()
        {
        }
    }
}
