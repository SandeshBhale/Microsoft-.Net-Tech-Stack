using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, ecount=0, ocount=0, t;

            Console.Write("Enter numbers to be taken : ");
            t = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= t; i++)
            {
                Console.Write("Enter number :");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    ecount++;
                }
                else
                {
                    ocount++;
                }
            }
            Console.WriteLine("Count of Even number is " + ecount);
            Console.WriteLine("Count of Odd number is " + ocount);
        }
    }
}
