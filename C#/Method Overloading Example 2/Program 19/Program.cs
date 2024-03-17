using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_19
{

    class search
    {
        public bool doSearch(int[] data, int a)
        {
            bool result = false;
            foreach(int f in data)
            {
                if (f == a)
                {
                    result = true;
                }
                return result;
            }
            return false;
        }
        public bool doSearch(string[] data, string a)
        {
            bool result = false;
            foreach(string f in data)
            {
                if( f == a)
                {
                    result = true;
                }
                return result;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            search s = new search();

            int[] array1 = { 1, 2, 3, 4, 5 };
            string[] array2 = { "apple", "banana", "mango" };


            if (s.doSearch(array1, 0))
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            if (s.doSearch(array2, "apple"))
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
