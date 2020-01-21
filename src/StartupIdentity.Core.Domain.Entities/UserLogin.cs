using Microsoft.AspNetCore.Identity;

namespace StartupIdentity.Core.Domain.Entities
{
    public class UserLogin : IdentityUserLogin<string>
    {
        public UserLogin() : base()
        {
        }
    }
}
