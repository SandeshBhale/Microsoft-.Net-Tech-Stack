using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Program_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, c, m, b, e, total;
            double per;

            Console.Write("Enter marks for Physics : ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Chemistry : ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Maths : ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Biology : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for English : ");
            e = Convert.ToInt32(Console.ReadLine());

            total = p + c + m + b + e;
            per = total / 5;

            if (per >= 70)
            {
                Console.WriteLine("Passed with Distintion !");
            }
            else
            {
                if(per >= 60)
                {
                    Console.WriteLine("Passed with Frist class !");
                }
                else
                {
                    if(per >= 50)
                    {
                        Console.WriteLine("Passed with Second class !");
                    }
                    else
                    {
                        if (per >= 40)
                        {
                            Console.WriteLine("Passed with Third class !");
                        }
                        else
                        {
                            Console.WriteLine("Failed !");
                        }
                    }
                }
            }
        }
    }
}
