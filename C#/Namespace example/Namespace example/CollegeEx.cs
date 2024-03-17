using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEx
{
    internal class College
    {
        private int collegeId;
        private string collegeName;
        private string address;
        private string city;

        public void addCollege(int cid,string cn,string add,string cit)
        {
            this.collegeId = cid;
            this.collegeName = cn;
            this.address = add;
            this.city = cit;
        }

        public void dispCollege()
        {
            Console.WriteLine("College ID is : " + collegeId);
            Console.WriteLine("College name is : " + collegeName);
            Console.WriteLine("College address is : " + address);
            Console.WriteLine("City name is : " + city);
        }
    }

    class Dept
    {
        public int deptId;
        public string deptName;
        public string deptHead;

        public void addDept(int id,String dn,string dh)
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
