using core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class CategoryRepo
    {
        ProductContext pc;

        public CategoryRepo()
        {
            this.pc = new ProductContext();
        }

        public List<Category> GetAllCat()
        {
            return this.pc.Categories.ToList();
        }
    }
}
