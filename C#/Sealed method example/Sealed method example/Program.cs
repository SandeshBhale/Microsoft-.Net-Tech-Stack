using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_method_example
{
    class A
    {
        public virtual void callMethod()
        {
            Console.WriteLine("Method A called ....!");
        }
    }

    class B : A
    {
        public sealed override void callMethod()
        {
            Console.WriteLine("Method B called ....!");
        }
    }

    // Code below this line will not work becouse we sealed the method
    //class C : B
    //{
    //    public void callMethod()
    //    {
    //        Console.WriteLine("Method C called ....!");
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.callMethod();
        }
    }
}
