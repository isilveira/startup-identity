using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupIdentity.Presentations.WebAPP.Models.Account
{
    public class AccountSignUpConfirmationViewModel
    {
        public string Email { get; set; }
        public bool DisplayConfirmAccountLink { get; internal set; }
        public string EmailConfirmationUrl { get; internal set; }

        public AccountSignUpConfirmationViewModel() { }
    }
}
