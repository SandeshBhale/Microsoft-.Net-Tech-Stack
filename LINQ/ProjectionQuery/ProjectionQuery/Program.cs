using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionQuery
{
    class Emp
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string Dept { get; set; }

        public void dispEmp()
        {
            Console.WriteLine(this.EmpId);
            Console.WriteLine(this.EmpName);
            Console.WriteLine(this.Dept);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();

            List<Emp> lst = new List<Emp>();

            lst.Add(new Emp() { EmpId = 1, EmpName = "Abhishek", Dept = "Computer" });
            lst.Add(new Emp() { EmpId = 2, EmpName = "Rushikesh", Dept = "Computer" });
            lst.Add(new Emp() { EmpId = 3, EmpName = "Rudresh", Dept = "Sales" });
            lst.Add(new Emp() { EmpId = 4, EmpName = "Suresh", Dept = "Sales" });
            lst.Add(new Emp() { EmpId = 5, EmpName = "Ramesh", Dept = "HR" });
            lst.Add(new Emp() { EmpId = 6, EmpName = "Kalpesh", Dept = "HR" });

            var v = from t in lst where t.Dept=="Computer" select new { t.EmpId,t.EmpName };

            foreach(var temp in v)
            {
                Console.WriteLine(temp.EmpId);
                Console.WriteLine(temp.EmpName);
            }
        }
    }
}
