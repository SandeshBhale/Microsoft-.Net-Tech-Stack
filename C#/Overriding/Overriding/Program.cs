using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Example_1
{
    class Shape
    {
        public virtual void calculateArea(double area)
        {
            Console.WriteLine("Calculated area :" + area);
        }
    }

    class circle : Shape
    {
        public override void calculateArea(double r)
        {
            double pi = 3.14;
            double area = pi * r * r;
            base.calculateArea(area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter redius of circle : ");
            double r = Convert.ToDouble(Console.ReadLine());
            circle c = new circle();
            c.calculateArea(r);
        }
    }
}
