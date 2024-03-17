using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Example_1
{
    class Parent
    {
        public virtual void P1Method()
        {
            Console.WriteLine("P1 Method at Parent");
        }

        public void P2Method()
        {
            Console.WriteLine("P2 Method at Parent");
        }
    }

    class Child : Parent
    {
        public override void P1Method()
        {
            Console.WriteLine("P1 Method at Child");
        }

        public new void P2Method()
        {
            Console.WriteLine("P2 method from parent to child");
        }

        public void C2Method()
        {
            Console.WriteLine("C2 Method at Child");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.P1Method();

            Child c = new Child();
            c.C2Method();
            c.P2Method();
        }
    }
}
