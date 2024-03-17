using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_Example_3
{
    internal class Program
    {
        class salaryEx : Exception
        {
            public string exmessage;

            public salaryEx(string exmessage)
            {
                this.exmessage = exmessage;
            }

            public void dispException()
            {
                Console.WriteLine("Exception occured");
            }
        }
        class Emp
        {
            private int empID;
            private string empName;
            private string deptname;
            private int salary;

            public void addEmp(int eid,string en,string dn,int sal)
            {
                if (sal < 10000 && dn == "COMP")
                    throw new salaryEx("Exception in comp salary");
                empID = eid;
                empName = en;
                deptname = dn;
                salary = sal;
            }

            public void dispEmp()
            {
                Console.WriteLine("Employee id is : " + empID);
                Console.WriteLine("Employee name is : " + empName);
                Console.WriteLine("Department is : " + deptname);
                Console.WriteLine("Salary is : " + salary);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Emp e = new Emp();
                e.addEmp(1, "sandesh", "COMP", 4000);
                e.dispEmp();
            }
            catch(salaryEx ex)
            {
                ex.dispException();
            }
        }
    }
}
