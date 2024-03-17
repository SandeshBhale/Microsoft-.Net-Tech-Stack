using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Properties_assignment
{
    class Product
    {
        public int productId;
        public string productName;
        public string mfgName;
        private double price;

        public Product(int pid,string pn,string mn,double pr)
        {
            this.productId = pid;
            this.productName = pn;
            this.mfgName = mn;
            this.price = pr;
        }

        public double propPrice
        {
            get
            {
                return price;
            }
        }
        public void addProduct()
        {
            Console.WriteLine("Product id is : " + productId);
            Console.WriteLine("Product name is :" + productName);
            Console.WriteLine("Mfg name is : " + mfgName);
            Console.WriteLine("Price is : " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> l = new List<Product>();

            int pid;
            string pn, mn;
            double pr;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter product id : ");
                pid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter product name : ");
                pn = Console.ReadLine();
                Console.WriteLine("Enter mfg name : ");
                mn = Console.ReadLine();
                Console.WriteLine("Enter price : ");
                pr = Convert.ToDouble(Console.ReadLine());
                l.Add(new Product(pid, pn, mn, pr));
            }

            Product p = new Product();

        }
    }
}
