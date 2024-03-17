using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_polymorphism_Ex2
{
    class Device
    {
        public virtual void Display()
        {
            Console.WriteLine("Device called ...!");
        }
    }

    class xerox : Device
    {
        public override void Display()
        {
            Console.WriteLine("Xerox callled ...!");
        }
    }

    class printer : Device
    {
        public override void Display()
        {
            Console.WriteLine("Printer called ...!");
        }
    }

    class moniter : Device
    {
        public override void Display()
        {
            Console.WriteLine("Moniter called ...!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Device d = new Device();
            Console.WriteLine("Enter 1 for calling xerox\nEnter 2 for calling printer\nEnter 3 for calling moniter");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    d = new xerox();
                    break;
                case 2:
                    d = new printer();
                    break;
                case 3:
                    d = new moniter();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            d.Display();
        }
    }
}
