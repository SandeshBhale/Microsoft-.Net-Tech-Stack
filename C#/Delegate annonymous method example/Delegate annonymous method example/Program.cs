using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_annonymous_method_example
{
    internal class Program
    {
        delegate int TDel(int a);
        delegate int T1Del(int a1, int b1, int c1);
        delegate int T2Del(int a2, int b2);
        delegate string T3Del(int a3);
        static void Main(string[] args)
        {
            TDel td = delegate (int n)
            {
                return n * n * n;
            };
            int cube = td(10);
            Console.WriteLine("Cube is " + cube);

            T1Del td1 = delegate (int x, int y, int z)
            {
                if (x > y && x > z)
                    return x;
                else if (y > x && y > z)
                    return y;
                else
                    return z;
            };
            int great = td1(10, 20, 30);
            Console.WriteLine("Greatest is " + great);

            T2Del td2 = delegate (int x1, int y1)
            {
                int z = x1 + y1;
                return z;
            };
            int add = td2(10,20);
            Console.WriteLine("Addition is " + add);

            T3Del td3 = delegate (int x3)
            {
                if (x3 % 2 == 0)
                    return "even";
                else
                    return "odd";
            };
            string eo = td3(5);
            Console.WriteLine("Number is " + eo);
        }
    }
}
