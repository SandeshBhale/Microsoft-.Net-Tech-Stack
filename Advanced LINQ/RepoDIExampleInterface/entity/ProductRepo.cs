using core;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web;

namespace entity
{
    public class ProductRepo : IProduct
    {
        ProductContext pc;

        public ProductRepo()
        {
            this.pc = new ProductContext();
        }

        public void Add(Product rec)
        {
            this.pc.Products.Add(rec);
            this.pc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.pc.Products.Find(id);
            this.pc.Products.Remove(rec);
            this.pc.SaveChanges();
        }

        public void Edit(Product rec)
        {
            this.pc.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            this.pc.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return this.pc.Products.ToList();
        }

        public Product GetById(long id)
        {
            var rec = this.pc.Products.Find(id);
            return rec;
        }

        //public List<Product> GetAll()
        //{
        //    return this.pc.Products.ToList();
        //}

        //public void Add(Product p)
        //{
        //    this.pc.Products.Add(p);
        //    this.pc.SaveChanges();
        //}

        //public Product FindId(Int64 id)
        //{
        //    var v = this.pc.Products.Find(id);
        //    return v;
        //}

        //public void Update(Product p)
        //{
        //    this.pc.Entry(p).State = System.Data.Entity.EntityState.Modified;
        //    this.pc.SaveChanges();
        //}

        //public void Delete(Int64 id)
        //{
        //    var rec = this.pc.Products.Find(id);
        //    this.pc.Products.Remove(rec);
        //    this.pc.SaveChanges();
        //}
    }
}
