using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_Advanced_Implicit
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
            sample s = new sample();
            s.sayHello();
        }
    }
}
