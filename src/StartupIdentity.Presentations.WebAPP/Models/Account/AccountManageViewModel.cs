using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartupIdentity.Presentations.WebAPP.Models.Account
{
    public class AccountManageViewModel
    {
        [Display(Name="User name")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        [Required(ErrorMessage ="{0} is required!")] 
        [Display(Name="Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public AccountManageViewModel() { }
    }
}
