using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 12, 15, 16, 45, 30, 33, 32, 93, 34, 19 };

            var r = from t in arr select t;

            foreach(int temp in r)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
