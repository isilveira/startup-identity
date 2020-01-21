using Microsoft.AspNetCore.Identity;

namespace StartupIdentity.Core.Domain.Entities
{
    public class UserRole : IdentityUserRole<string>
    {
        public UserRole() : base()
        {
        }
    }
}
