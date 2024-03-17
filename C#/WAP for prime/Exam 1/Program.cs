using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int divisors = 0;

                for (int n = 2; n < arr[i]; n++)
                {
                    if (arr[i] % n == 0)
                    {
                        divisors++;
                        break; // Break if a divisor is found
                    }
                }
                // If no divisors other than 1 and the number itself, it's prime
                if (divisors == 0 && arr[i] > 1)
                {
                    count++;
                }
            }
            Console.WriteLine("Count of prime numbers: " + count);
        }
    }
}
