using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Genric_Example
{
    class sample<T>
    {
        public bool search(T[]data,T f)
        {
            foreach(T temp in data)
            {
                if (temp.Equals(f))
                {
                    return true;
                }
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sample<int> s = new sample<int>();
            int[] arr = {1,2,3,4,5,6,7,8,9};

            sample<string> s1 = new sample<string>();
            string[] arrr = {"apple","banana","grpe"};

            if (s.search(arr,0))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            if (s1.search(arrr, "mango"))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
