using Microsoft.AspNetCore.Identity;
using System;

namespace StartupIdentity.Core.Domain.Entities
{
    public class User : IdentityUser<string>
    {
        public User() : base()
        {
            Id = Guid.NewGuid().ToString();
        }

        public User(string userName) : base(userName)
        {
        }
    }
}
