using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];

            int esum=0,osum=0;

            for (int i = 0; i< arr.Length; i++)
            {
                Console.Write("Enter number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (arr[i] % 2 == 0)
                {
                    esum = esum + arr[i];
                }
                else
                {
                    osum = osum + arr[i];
                }
            }

            Console.WriteLine("Sum of even number is : " + esum);
            Console.WriteLine("Sum of odd number is : " + osum);
        }
    }
}
