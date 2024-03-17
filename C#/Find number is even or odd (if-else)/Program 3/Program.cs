using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.Write("Given number is Even");
            }
            else
            {
                Console.WriteLine("Given number is odd");
            }
        }
    }
}
