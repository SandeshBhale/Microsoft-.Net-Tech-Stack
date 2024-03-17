using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method_Example
{
    abstract class Sample
    {
        public abstract void methodM1();
    }

    class Test : Sample
    {
        public override void methodM1()
        {
            Console.WriteLine("Method M1 Called ....!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.methodM1();
        }
    }
}
