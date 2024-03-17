using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolEX
{
    internal class School
    {
        private int schoolId;
        private string schoolName;
        private string address;
        private string city;

        public void addSchool(int sid,string sname,string add,string city)
        {
            this.schoolId = sid;
            this.schoolName = sname;
            this.address = add;
            this.city = city;
        }

        public void dispSchool()
        {
            Console.WriteLine("School id is : " + schoolId);
            Console.WriteLine("School name is : "+ schoolName);
            Console.WriteLine("School address is : " + address);
            Console.WriteLine("City is : " + city);
        }
    }

    class Dept
    {
        public int deptId;
        public string deptName;
        public string deptHead;

        public void addDept(int id, String dn, string dh)
        {
            this.deptId = id;
            this.deptName = dn;
            this.deptHead = dh;
        }

        public void dispDept()
        {
            Console.WriteLine("Department id is : " + deptId);
            Console.WriteLine("Department name is : " + deptName);
            Console.WriteLine("Department head is : " + deptHead);
        }
    }
}
