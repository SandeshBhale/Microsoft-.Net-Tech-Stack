using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Example
{
    class Sample
    {
        private string name;

        public Sample(string name)
        {
            this.name = name;
        }

        public string PopName
        {
            get
            {
                return name;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample("Sandesh");
            Console.WriteLine(s.PopName);
        }
    }
}
