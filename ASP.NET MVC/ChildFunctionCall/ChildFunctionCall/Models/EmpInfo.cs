using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildFunctionCall.Models
{
    public class EmpInfo
    {
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public static List<EmpInfo> GetEmps()
        {
            List<EmpInfo> lst = new List<EmpInfo>();
            lst.Add(new EmpInfo() { EmpName = "Kishan", Address = "PCMC", Email = "kishan.gmail", Mobile = "123456789" });
            lst.Add(new EmpInfo() { EmpName = "Rushi", Address = "Akurdi", Email = "rushi.gmail", Mobile = "123456789" });
            lst.Add(new EmpInfo() { EmpName = "Shingle", Address = "Chinchvad", Email = "shinlge.gmail", Mobile = "123456789" });
            lst.Add(new EmpInfo() { EmpName = "SidD", Address = "Baner", Email = "sidd.gmail", Mobile = "123456789" });
            lst.Add(new EmpInfo() { EmpName = "LoxC", Address = "Tathwde", Email = "lox.gmail", Mobile = "123456789" });
            return lst;
        }
    }
}