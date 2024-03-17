using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Statically_typed_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment is needed
            var a=0;
            Console.WriteLine(a);
            a = 11;
            Console.WriteLine(a);

            var v = new { EmpId = 1,Empname = "Ramesh",EmpDOB = "12/12/12"};
            Console.WriteLine(v.EmpId);
            Console.WriteLine(v.Empname);
            Console.WriteLine(v.EmpDOB);
        }
    }
}
