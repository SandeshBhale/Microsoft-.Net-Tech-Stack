using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Short_Syntax
{   
    class Sample
    {
        public string hello { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Console.WriteLine(s.hello);
        }
    }
}
