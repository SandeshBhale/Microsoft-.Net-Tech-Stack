using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_example
{
    internal class Program
    {
        delegate int ODel(int a);
        delegate bool Odel(int a);
        delegate string OdEl(int a);
        delegate int TDel(int a, int b);
        delegate int ThDel(int a, int b, int c);
        static void Main(string[] args)
        {
            ODel sq = (a) => a * a;
            int r = sq(10);
            Console.WriteLine("Square is : " + r);

            TDel ad = (a, b) => a + b;
            r = ad(10, 20);
            Console.WriteLine("Addition is :" + r);

            ODel cb = (a) => a * a * a;
            r = cb(10);
            Console.WriteLine("Cube is :" + r);

            TDel mul = (a, b) => a * b;
            r = mul(10, 20);
            Console.WriteLine("Multiplication is :" + r);

            Odel evod = (a) => a%2 == 0;
            bool r1 = evod(10);
            Console.WriteLine("If num Even the true else false :" + r1);

            TDel gt2 = (a, b) => a > b ? a : b;
            r = gt2(10, 20);
            Console.WriteLine("Greater number is : "+r);

            ThDel gt = (a, b, c) => a > b && a > c ? a : (b > a && b > c) ? b : c;
            r = gt(30,20,10);
            Console.WriteLine("Greatest number is : " + r);

            OdEl evn = (a) => a % 2 == 0 ? "Even" : "Odd";
            string r2 = evn(13);
            Console.WriteLine("Number is Even or Odd : " + r2);
        }
    }
}
