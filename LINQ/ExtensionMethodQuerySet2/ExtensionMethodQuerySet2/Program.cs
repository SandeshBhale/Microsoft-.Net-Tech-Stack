using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodQuerySet2
{
    class Emp
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public double Salary { get; set; }

        public string Dept { get; set; }

        public void dispEmp()
        {
            Console.WriteLine("Emp id is :" + this.EmpId);
            Console.WriteLine("Emp name is :" + this.EmpName);
            Console.WriteLine("Emp salary is :" + this.Salary);
            Console.WriteLine("Dept is :" + this.Dept);
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

            //var v = lst.OrderBy(p => p.Salary);
            //var v = lst.OrderByDescending(p => p.Salary);
            //var v = lst.Take(1);
            //var v = lst.Skip(1);
            //foreach (var temp in v)
            //{
            //    temp.dispEmp();
            //}
            //var v = lst.Any();
            //if (v != null)
            //{
            //    Console.Write("Record found");
            //}

            var sum = lst.Sum(p => p.Salary);
            Console.WriteLine("Sum of salaries : "+sum);

            var min = lst.Min(p => p.Salary);
            Console.WriteLine("Min salary is : " + min);

            var max = lst.Max(p => p.Salary);
            Console.WriteLine("Max salary is : " + max);

            var avg = lst.Average(p => p.Salary);
            Console.WriteLine("Avergage salary is : " + avg);
        }
    }
}
