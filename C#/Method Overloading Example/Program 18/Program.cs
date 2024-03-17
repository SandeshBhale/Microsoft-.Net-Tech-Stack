using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_18
{
    class Shape
    {
        public void calculateArea(int r)
        {
            double pi = 3.14;
            double area = pi * r * r;
            Console.WriteLine("Area of Circle is : " + area);
        }

        public void calculateArea(int l,int b)
        {
            double area = 2 * l * b;
            Console.WriteLine("Area of Rectangle is : " + area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.calculateArea(4, 5);
            s.calculateArea(4);
        }
    }
}
