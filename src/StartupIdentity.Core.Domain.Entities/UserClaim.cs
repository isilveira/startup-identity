using Microsoft.AspNetCore.Identity;

namespace StartupIdentity.Core.Domain.Entities
{
    public class UserClaim : IdentityUserClaim<string>
    {
        public UserClaim() : base()
        {
        }
    }
}
