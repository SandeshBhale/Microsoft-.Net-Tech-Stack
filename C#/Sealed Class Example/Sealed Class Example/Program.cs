using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sealed_Class_Example
{
    class Demo
    {
        //method is not overrideen cause its sealed
        public sealed void callMethod()
        {
            Console.WriteLine("Method called");
        }
    }

    class Test : Demo
    {
        public void testMethod()
        {
            Console.WriteLine("Code under Test class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.testMethod();
        }
    }
}
