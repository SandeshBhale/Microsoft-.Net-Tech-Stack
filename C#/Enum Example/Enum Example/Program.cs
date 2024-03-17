using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Example
{
    enum catagory { platinum=1,diamond=2,gold=3,silver=4 };
    internal class Program
    {
        static void Main(string[] args)
        {
            double price, amount, discount = 0;
            int catcode, qty;
            string pname;

            Console.Write("Enter catagary code: ");
            catcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product name : ");
            pname = Console.ReadLine();
            Console.Write("Engter quantity : ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter price :");
            price = Convert.ToDouble(Console.ReadLine());

            amount = price * qty;
            Console.WriteLine("Amount is : "+ amount);

            switch (catcode)
            {
                case (int)catagory.platinum:
                    discount = amount * 0.5;
                    break;

                case (int)catagory.diamond:
                    discount = amount * 0.4;
                    break;

                case (int)catagory.gold:
                    discount = amount * 0.3;
                    break;

                case (int)catagory.silver:
                    discount = amount * 0.2;
                    break;

                default:
                    Console.WriteLine("Invalid catagory");
                    break;
            }

            Console.WriteLine("Discount amount is :" + discount);
        }
    }
}
