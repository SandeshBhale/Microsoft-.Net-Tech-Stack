using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationExample.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Please Enter Id")]
        [Display(Name = "Enter Id")]
        public long CustId { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Enter Name")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Name should be 5-10 characters")]
        public string CustName { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "Adress must be 10-30 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Email must be 10-20 characters")]
        public string EmaiId { get; set; }

        [Required(ErrorMessage = "Please Enter Mobile Number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be 10 digit")]
        public string MobNo { get; set; }

        [Required(ErrorMessage = "Please Credit Limit")]
        [Range(1000, 100000, ErrorMessage = "Enter values between 1000-100000")]
        [EvenOdd(ErrorMessage ="Credit Limit Should be Even")]
        public decimal CreditLimit { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Compare("Pass",ErrorMessage ="Password should be same")]
        [DataType(DataType.Password)]
        public string ConfPass { get; set; }
    }
}