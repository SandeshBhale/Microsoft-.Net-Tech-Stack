using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstExample.Models
{
    public class Customer
    {
        public long CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public string City { get; set; }
    }
}