using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_collection
{
    class Product
    {
        public int productId;
        public string productName;
        public string mfgName;
        public int price;
        
        public Product(int pid,string pn,string mn,int pr)
        {
            this.productId = pid;
            this.productName = pn;
            this.mfgName = mn;
            this.price = pr;
        }
        public void showProduct()
        {
            Console.WriteLine("Product id is : " + this.productId);
            Console.WriteLine("Product name is : " + this.productName);
            Console.WriteLine("Mfg name is : " + this.mfgName);
            Console.WriteLine("Price is : " + this.price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int pid,pr;
            string pn, mn;

            List<Product> l = new List<Product>();

            Console.WriteLine("Enter Product details ========>");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter product id :");
                pid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product name :");
                pn = Console.ReadLine();
                Console.Write("Enter mfg name : ");
                mn = Console.ReadLine();
                Console.Write("Price is : ");
                pr = Convert.ToInt32(Console.ReadLine());


                //for (int i = 0; i < 1; i++)
                //{
                    l.Add(new Product(pid, pn, mn, pr));
                //}

            }
            Console.WriteLine("Products are =======>");
            for (int i = 0; i < 5; i++)
            {
                l[i].showProduct();
            }
        }
    }
}
