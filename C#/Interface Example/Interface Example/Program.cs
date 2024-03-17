using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    interface areaInt
    {
        double calculateArea();
    }

    class sample : areaInt
    {
        private double r;
        public sample(double r)
        {
            this.r = r;
        }
        public double calculateArea()
        {
            double area = 3.14 * r * r;
            return area;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample(12);
            Console.WriteLine("Area is : " + s.calculateArea());
        }
    }
}
