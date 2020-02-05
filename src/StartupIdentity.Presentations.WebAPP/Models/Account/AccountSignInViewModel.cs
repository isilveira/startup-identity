using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartupIdentity.Presentations.WebAPP.Models.Account
{
    public class AccountSignInViewModel
    {
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "{0} must be a valid format!")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public AccountSignInViewModel() { }
    }
}
