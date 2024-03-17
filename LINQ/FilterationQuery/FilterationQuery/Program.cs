using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterationQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 12, 14, 15, 32, 43, 53, 93, 62, 9, 18, 45,74 };

            var v = from t in arr where t > 50 && t%2==0 select t;

            foreach(int temp in v)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
