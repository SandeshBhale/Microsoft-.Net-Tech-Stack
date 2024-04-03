using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthorizationExample.Models
{
    public class Product
    {
        [Key]
        public Int64 ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
    }
}