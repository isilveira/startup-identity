using Microsoft.AspNetCore.Identity;

namespace StartupIdentity.Core.Domain.Entities
{
    public class Role : IdentityRole<string>
    {
        public Role() : base()
        {
        }

        public Role(string roleName) : base(roleName)
        {
        }
    }
}
