using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                if(num2 > num3)
                {
                    Console.WriteLine("First number is greatest");
                }
                else
                {
                    Console.WriteLine("Second number is greatest");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Second number is greatest");
                }
                else
                {
                    Console.WriteLine("Third number is greatest");
                }
            }
        }
    }
}
