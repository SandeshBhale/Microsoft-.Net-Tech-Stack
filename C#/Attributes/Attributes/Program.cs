using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class ConstInfo : Attribute
    {
        public string  constName { get; set; }

        public string compName { get; set; }
    }

    [ConstInfo(constName="Ramesh",compName = "RIBuild")]

    class Project
    {
        private int projectId;
        private string projectName;
        private string cityName;
        private double budjet;

        public void addProject(int pid,string pn,string cn,double b)
        {
            this.projectId = pid;
            this.projectName = pn;
            this.cityName = cn;
            this.budjet = b;
        }

        public void dispProject()
        {
            Console.WriteLine("Project id is : " + projectId);
            Console.WriteLine("Project name is : " + projectName);
            Console.WriteLine("City name is : " + cityName);
            Console.WriteLine("Budjet is : " + budjet + " lakhs");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Project p = new Project();
            p.addProject(1, "Building", "Pune", 55.33);
            p.dispProject();
        }
    }
}
