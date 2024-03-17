using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cube;

            Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            cube = num * num * num;

            Console.WriteLine("Cube of given number is : " + cube);
        }
    }
}
