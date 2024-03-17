using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,3];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Enter digits :");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" "+ arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}