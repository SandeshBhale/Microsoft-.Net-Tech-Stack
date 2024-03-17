using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_Example_2
{
    class priceEx : Exception
    {
        private string exmsg;
        public priceEx(string exmsg)
        {
            this.exmsg = exmsg;
        }

        public void dispException()
        {
            Console.WriteLine("Exception occured");
        }
    }
    class Product
    {
        private int productID;
        private string productName;
        private string mfgName;
        private int price;

        public void addProduct(int pid, string pname,string mn,int pr)
        {
            this.productID = pid;
            this.productName = pname;
            this.mfgName = mn;
            this.price = pr;
        }

        public void dispProduct()
        {
            if (price < 0)
                throw new priceEx("Price should not be less than zero or zero");
            Console.WriteLine("Prouct id is : " + productID);
            Console.WriteLine("Product name is :" + productName);
            Console.WriteLine("Mfg name is : " + mfgName);
            Console.WriteLine("Price is : " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product p = new Product();
                p.addProduct(1, "Mouse", "Intex", -450);
                p.dispProduct();
            }

            catch(priceEx ex)
            {
                ex.dispException();
            }
            
        }
    }
}
