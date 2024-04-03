using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthorizationExample.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Email required")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Password required")]
        public string Password { get; set; }
    }
}