using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_initialization_of_object
{   
    class Sample
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public void dispEmp()
        {
            Console.WriteLine("Emp Id : " + EmpId);
            Console.WriteLine("Emp Name : " + EmpName);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample() { EmpId = 1, EmpName = "Kamlesh" };
            s.dispEmp();
        }
    }
}
