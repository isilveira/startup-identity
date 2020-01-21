using Microsoft.AspNetCore.Identity;

namespace StartupIdentity.Core.Domain.Entities
{
    public class User : IdentityUser<string>
    {
        public User() : base()
        {
        }

        public User(string userName) : base(userName)
        {
        }
    }
}
