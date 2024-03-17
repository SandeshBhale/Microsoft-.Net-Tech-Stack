using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolEX;
using CollegeEx;

namespace Namespace_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School s = new School();
            s.addSchool(1, "Bal vidya mandir", "Vaibhav nagar", "Parbhani");
            s.dispSchool();

            College c = new College();
            c.addCollege(1, "GHRIET", "Wagholi", "Pune");
            c.dispCollege();

            CollegeEx.Dept d = new CollegeEx.Dept();
            d.addDept(1, "Sales", "Mahesh");
            d.dispDept();

            SchoolEX.Dept ds = new SchoolEX.Dept();
            ds.addDept(1, "Tax", "Jhon");
            ds.dispDept();
        }
    }
}
