using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySyntax_ExtensionMethod
{
    class Emp
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public double Salary { get; set; }

        public string Dept { get; set; }

        public void dispEmp()
        {
            Console.WriteLine("Emp Name is : " + EmpName);
            Console.WriteLine("Salary is : " + Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();

            List<Emp> lst = new List<Emp>();

            lst.Add(new Emp() { EmpId = 1, EmpName = "Ramesh", Salary = 12000, Dept = "Computer" });
            lst.Add(new Emp() { EmpId = 2, EmpName = "Suresh", Salary = 22000, Dept = "Computer" });
            lst.Add(new Emp() { EmpId = 3, EmpName = "Kalpesh", Salary = 32000, Dept = "Purchase" });
            lst.Add(new Emp() { EmpId = 4, EmpName = "Rupesh", Salary = 42000, Dept = "Purchase" });
            lst.Add(new Emp() { EmpId = 5, EmpName = "Yadnesh", Salary = 12000, Dept = "Sales" });
            lst.Add(new Emp() { EmpId = 6, EmpName = "Devesh", Salary = 32000, Dept = "Sales" });
            lst.Add(new Emp() { EmpId = 7, EmpName = "Kashish", Salary = 22000, Dept = "Sales" });
            lst.Add(new Emp() { EmpId = 8, EmpName = "Vashish", Salary = 34000, Dept = "Manager" });
            lst.Add(new Emp() { EmpId = 9, EmpName = "Kavish", Salary = 43000, Dept = "Manager" });
            lst.Add(new Emp() { EmpId = 10, EmpName = "Ashish", Salary = 50000, Dept = "Manager" });

            //var v = (from t in lst where t.Dept == "Computer" orderby t.Salary descending select t).Take(1);
            //var v = from t in lst.Where(t=>t.Dept == "Computer").OrderByDescending(p => p.Salary) select t;
            //var v = from t in lst.OrderByDescending(p=>p.Salary).Take(1) select t;
            var v = from t in lst.OrderByDescending(p => p.Salary).Skip(1).Take(1) select t;

            foreach (var temp in v)
            {
                temp.dispEmp();
            }
        }
    }
}
