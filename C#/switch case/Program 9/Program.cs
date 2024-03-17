using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            double discount,after;
            String cityname;

            Console.Write("Enter amount : ");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter city name : ");
            cityname = Console.ReadLine();

            switch (cityname)
            {
                case "Pune":
                    discount = amount * 0.4;
                    break;

                case "Mumbai":
                    discount = amount * 0.3;
                    break;

                case "PCMC":
                    discount = amount * 0.2;
                    break;

                case "Delhi":
                    discount = amount * 0.1;
                    break;

                default:
                    discount = amount * 0.05;
                    break;
            }

            after = amount - discount;

            Console.WriteLine("Discounted amount will be " + discount);
            Console.WriteLine("Amount after discount " + after);
        }
    }
}
