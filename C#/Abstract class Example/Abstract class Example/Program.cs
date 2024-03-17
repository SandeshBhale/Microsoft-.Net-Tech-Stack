using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Example
{
    abstract class Sample
    {
        public abstract void methodM1();
        public abstract void methodM2();
    }

    class Test : Sample
    {
        public override void methodM1()
        {
            Console.WriteLine("Method M1 Called ....!");
        }

        public override void methodM2()
        {
            Console.WriteLine("Method M2 Called ....!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.methodM1();
            t.methodM2();
        }
    }
}
