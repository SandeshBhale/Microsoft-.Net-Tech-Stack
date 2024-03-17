using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day,month;
            Console.Write("Enter Birtday Day : "); 
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Birtday Month : ");
            month = Convert.ToInt32(Console.ReadLine());
            if(DateTime.Now.Day==day && DateTime.Now.Month == month)
            {
                Console.WriteLine("Happy Birthday !!");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
