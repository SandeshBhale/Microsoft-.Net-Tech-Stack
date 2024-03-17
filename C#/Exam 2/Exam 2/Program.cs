using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    class Course
    {
        private int CourseId;
        private string CourseName;
        private double Duration;
        private int Fees;

        public void insertData(int cid, string cname, double dur, int pr)
        {
            CourseId = cid;
            CourseName = cname;
            Duration = dur;
            Fees = pr;
        }

        public void showData()
        {
            if (Fees > 10000)
            {
                Console.WriteLine("==== Course having fees > 10000 ====");
                Console.WriteLine("Course id is :" + CourseId);
                Console.WriteLine("Course name is : " + CourseName);
                Console.WriteLine("Course duration is :" + Duration);
                Console.WriteLine("Course fees is : " + Fees);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Course c = new Course();
              c.insertData(1, "c#", 1.5, 50000);
              c.showData();*/

            Course[] c = new Course[5];

            int cid,fees;
            double dur;
            string cname;

            for(int i=0; i < c.Length; i++)
            {
                c[i] = new Course();
                Console.WriteLine("==== Enter data for course ====");
                Console.Write("Enter course id : ");
                cid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter course name : ");
                cname = Console.ReadLine();
                Console.Write("Enter course duration : ");
                dur = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter course fees : ");
                fees = Convert.ToInt32(Console.ReadLine());
                c[i].insertData(cid,cname,dur,fees);
            }

            for(int i=0; i < c.Length; i++)
            {
                c[i].showData();
            }
        }
    }
}
