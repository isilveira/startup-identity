using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupIdentity.Presentations.WebAPP.Models.Account
{
    public class AccountSignInViewModel
    {
        public string ReturnUrl { get; set; }
        public List<AuthenticationScheme> AuthenticationSchemes { get; set; }
        public AccountSignInViewModel() { }
        public AccountSignInViewModel(string returnUrl = null, List<AuthenticationScheme> authenticationSchemes = null)
        {
            ReturnUrl = returnUrl;
            AuthenticationSchemes = authenticationSchemes;
        }

        public string Credential { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
