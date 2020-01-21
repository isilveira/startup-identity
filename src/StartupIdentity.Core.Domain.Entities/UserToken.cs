using Microsoft.AspNetCore.Identity;

namespace StartupIdentity.Core.Domain.Entities
{
    public class UserToken : IdentityUserToken<string>
    {
        public UserToken() : base()
        {
        }
    }
}
