﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderQuery
{
    class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public string Dept { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();

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

            // var v = from t in lst orderby t.Salary ascending select t;
            // var v = from t in lst orderby t.Salary ascending, t.EmpName ascending select t;
            var v = from t in lst orderby t.Salary select new { t.EmpName, t.Salary };

            foreach (var temp in v)
            {
                Console.WriteLine(temp.EmpName +" : "+ temp.Salary);
            }
        }
    }
}