using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            double discount;
            string cityname;

            Console.Write("Enter city name : ");
            cityname = Console.ReadLine();

            Console.Write("Enter amount : ");
            amount = Convert.ToInt32(Console.ReadLine());

            if (cityname == "Pune" && amount>=10000)
            {
                discount = amount * 0.2;
            }
            else
            {
                discount = amount * 0.1;
            }

            Console.Write("Discount is " + discount);
        }
    }
}
