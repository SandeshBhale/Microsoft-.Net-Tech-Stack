using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using core;

namespace web
{
    public interface IProduct
    {
        List<Product> GetAll();
        void Add(Product rec);
        Product GetById(Int64 id);
        void Edit(Product rec);
        void Delete(Int64  id);
    }
}