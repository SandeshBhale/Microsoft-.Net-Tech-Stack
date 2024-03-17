using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter values :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
