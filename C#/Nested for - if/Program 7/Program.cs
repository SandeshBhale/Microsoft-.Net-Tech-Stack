using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, esum=0, osum=0, t;

            Console.Write("Enter how many number you want to insert : ");
            t = Convert.ToInt32(Console.ReadLine());

            for( int i = 1; i <= t; i++)
            {
                Console.Write("Enter number : ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num %2== 0)
                {
                    esum = esum + num;
                }
                else
                {
                    osum = osum + num;
                }
            }

            Console.WriteLine("Sum of all Even numbers is " + esum);
            Console.WriteLine("Sum of all Odd numbers is " + osum);
        }
    }
}
