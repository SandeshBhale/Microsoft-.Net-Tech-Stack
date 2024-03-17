using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Genric_Example_multiple
{
    class Sample<A,B,C,D>
    {
        public void call(A a,B b,C c,D d)
        {
            Console.WriteLine("A is : " + a);
            Console.WriteLine("B is : " + b);
            Console.WriteLine("C is : " + c);
            Console.WriteLine("D is : " + d);
            Console.WriteLine("\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample<int,string,int,string> s = new Sample<int,string,int,string>();
            s.call(1, "apple", 2, "mango");

            Sample<int, double, int, string> s1 = new Sample<int, double, int, string>();
            s1.call(1, 55.33, 2, "mango");

            Sample<string,int,double,string> s3 = new Sample<string,int,double,string>();
            s3.call("apple", 1, 22.33, "mango");
        }
    }
}