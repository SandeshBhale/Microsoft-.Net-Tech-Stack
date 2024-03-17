using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            int max=0;

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter numbers :");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum number is : "+max);
        }
    }
}
