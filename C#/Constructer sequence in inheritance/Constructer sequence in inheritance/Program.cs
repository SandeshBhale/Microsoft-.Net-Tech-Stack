using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer_sequence_in_inheritance
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Default parent method");
        }

        public Parent(int x)
        {
            Console.WriteLine("Parent with one int paramter");
        }

        public Parent(String x)
        {
            Console.WriteLine("Parent with one string parameter");
        }

        public Parent(int x,string y)
        {
            Console.WriteLine("Parent with one int and one string paremter");
        }
    }

    class child : Parent
    {
        public child()
        {
            Console.WriteLine("Default child method");
        }

        public child(int x): base(10)
        {
            Console.WriteLine("Child with one int paramter");
        }

        public child(string x):base("sandesh")
        {
            Console.WriteLine("Child with one string parameter");
        }

        public child(int x,string y):base(10,"sandesh")
        {
            Console.WriteLine("Child with one int and string paramter");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            child c1 = new child(10);
            child c2 = new child("sandesh");
            child c3 = new child(10, "sandesh");
            
        }
    }
}
