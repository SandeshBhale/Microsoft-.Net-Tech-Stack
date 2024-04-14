using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.ComponentModel.DataAnnotations;

namespace core
{
    public class Category
    {
        [Key]
        public Int64 CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
