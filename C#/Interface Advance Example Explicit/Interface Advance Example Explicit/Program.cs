using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Advance_Example_Explicit
{
    interface A1Int
    {
        void sayHello();
    }

    interface B1Int
    {
        void sayHello();
    }

    class sample : A1Int, B1Int
    {
        public void sayHello()
        {
            Console.WriteLine("sayHello called ....!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A1Int a = new sample();
            a.sayHello();

            B1Int b = new sample();
            b.sayHello();
        }
    }
}
