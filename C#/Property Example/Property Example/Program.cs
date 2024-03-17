using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Example
{
    class Sample
    {
        private double price;

        public double propPrice
        {
            set
            {
                if (value > 0)
                { 
                    price = value;
                    Console.WriteLine("Price is Okey");
                }

                else
                {
                    Console.WriteLine("Invalid Price");
                }
            }
            get
            {
                return price;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.propPrice = 400;
        }
    }
}
