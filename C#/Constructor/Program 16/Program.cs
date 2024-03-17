using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_16
{
    public class Product
    {
        private int productid;
        private string productname;
        private double price;

        public void addProduct(int pid,string pname,double pr)
        {
            int productid = pid;
            string productname = pname;
            double price = pr;
        }
        
        public void dispProduct()
        {
            Console.WriteLine("Product id is " + productid);
            Console.WriteLine("Product name " + productname);
            Console.WriteLine("Price" + price);
        }

        public Product()
        {

        }

        public Product(int pid)
        {
            productid = pid;
        }

        public Product(int pid,string pname)
        {
            productid = pid;
            productname = pname;
        }

        public Product(int pid,string pname,double pr)
        {
            productid = pid;
            productname = pname;
            price = pr;
        }

        ~Product()
        {
            Console.WriteLine("Destructer is called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.dispProduct();

            Product p1 = new Product(1);
            p1.dispProduct();

            Product p2 = new Product(2, "Fan");
            p2.dispProduct();

            Product p3 = new Product(3, "Cooler", 4500);
            p3.dispProduct();
        }
    }
}
