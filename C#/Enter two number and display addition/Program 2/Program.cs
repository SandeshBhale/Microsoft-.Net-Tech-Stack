using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.Write("Enter Frist number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine("Addition of given two number is : " + sum);
        }
    }
}
