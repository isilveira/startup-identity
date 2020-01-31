using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupIdentity.Presentations.WebAPP.Models.Account
{
    public class AccountSignUpViewModel
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
