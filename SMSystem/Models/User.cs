using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMSystem.Models
{
    public enum UserType
    {
        Admin, Student, Teacher   
    }


    public class User
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:250)]
        [Display(Name = "User Name")]
        public string  UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string  PasswordHash { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [DefaultValue(false)]
        public bool  IsConformed { get; set; }


        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required]
        public UserType UserType { get; set; }


           

    }


    

}