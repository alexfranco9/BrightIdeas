using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class LoginUser
    {
        [Required]
        [Display(Name = "Email:")]
        public string LoginEmail { get; set; }

        [Required]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}