using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMSystem.ViewModel.UserViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "UserName is Required")]
        [StringLength(maximumLength: 250)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }

    }
}