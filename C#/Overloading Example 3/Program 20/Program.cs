using System;
using System.Runtime.CompilerServices;

namespace Program_20
{
    class mobileBill
    {
        public string mobileno;
        public int noofcalls;
        public double callrate;

        public void addBill(string mn, int nc, double cr)
        {
            mobileno = mn;
            noofcalls = nc;
            callrate = cr;
        }
    }

    class msebBill
    {
        public int meterno;
        public int noofunits;
        public double rateperunit;

        public void addBill(int mn, int nu, int ru)
        {
            meterno = mn;
            noofunits = nu;
            rateperunit = ru;
        }
    }

    class bill
    {
        public int billno;
        public string date;
        public string name;

        public void addBill(int bn, string dt, string n)
        {
            billno = bn;
            date = dt;
            name = n;
        }

        public void dispBill()
        {
            Console.WriteLine("Customer name : " + name);
            Console.WriteLine("Bill no : " + billno);
            Console.WriteLine("Date : " + date);
        }

        public void dispBill(int nc,double cr)
        {
            Console.WriteLine("Mobile bill :" + (nc * cr));
        }

        public void dispBill(int nu, int ru)
        {
            Console.WriteLine("MSEB bill : " + (nu * ru));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bill b = new bill();
            b.addBill(1, "29/01/2024", "Sandesh");
            b.dispBill();
            b.dispBill(1567, 0.5);
            b.dispBill(75, 15);
        }
    }
}
