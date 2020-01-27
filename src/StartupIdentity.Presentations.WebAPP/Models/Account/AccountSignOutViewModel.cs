using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupIdentity.Presentations.WebAPP.Models.Account
{
    public class AccountSignOutViewModel
    {
        public string RedirectUrl { get; set; }
        public AccountSignOutViewModel()
        {
            RedirectUrl = "~/";
        }
    }
}
