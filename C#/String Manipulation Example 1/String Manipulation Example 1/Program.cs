using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace String_Manipulation_Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] arr = new string[5];
            int max=0;
            max = arr[0].Length;

            //Input taken here
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter string :");
                arr[i] = Console.ReadLine();
            }
            
            //To find maximum length 
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i].Length)
                {
                    max = arr[i].Length;
                }
            }

            //print
            for(int i = 0; i < arr.Length; i++)
            {
                if (max == arr[i].Length)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
