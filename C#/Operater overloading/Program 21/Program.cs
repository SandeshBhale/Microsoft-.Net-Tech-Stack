using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_21
{
    class Point
    {
        public int x;
        public int y;

        public void initPoint(int a, int b)
        {
            this.x = a;
            this.y = b;
        }

        public void disPoint()
        {
            Console.WriteLine("X coordinate is " + x);
            Console.WriteLine("Y coordinate is " + y);
        }


        public static Point operator ++(Point t)
        {
            t.x++;
            t.y++;
            return t;
        }

        public static Point operator --(Point t)
        {
            t.x--;
            t.y--;
            return t;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Point p = new Point();
                p.initPoint(12, 13);

                Console.WriteLine("==============Original Coordinates==========");

                p.disPoint();

                p++;
                p++;

                Console.WriteLine("================After increment============");

                p.disPoint();

                p--;
                p--;
                p--;
                p--;

                Console.WriteLine("================After Decrement============");

                p.disPoint();
            }
        }
    }
}
