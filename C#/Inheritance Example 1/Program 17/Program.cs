using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_17
{
    class Bill 
    {
        private int billno;
        private string customername;
        private string billdate;

        public void addBill(int bn,string cn,string bd)
        {
            billno = bn;
            customername = cn;
            billdate = bd;
        }

        public void dispBill()
        {
            Console.WriteLine("<================= This is Bill Details Section ===============>");
            Console.WriteLine("Bill number : " + billno);
            Console.WriteLine("Customer name : " + customername);
            Console.WriteLine("Bill date : " + billdate);
        }

    }

    class Mobile:Bill
    {
        private string mobileno;
        private int noofcalls;
        private int billrate;

        public void addMobileBill(int bn, string cn, string bd, string mn,int nc,int br)
        {
            addBill(bn,cn,bd);
            mobileno = mn;
            noofcalls = nc;
            billrate = br;
        }

        public void dispMobBill()
        {
            dispBill();
            Console.WriteLine("<================= This is Mobile Bill Section ===============>");
            Console.WriteLine("Mobile Number : " + mobileno);
            Console.WriteLine("Number of calls : " + noofcalls);
            Console.WriteLine("Bill rate : " + billrate);
            Console.WriteLine("Mobile bill : " + (noofcalls * billrate));
        }
    }
    class msebBill:Bill
    {
        public int meterno;
        public int nounits;
        public int unitrate;

        public void addMsebBill(int mn,int nu,int ur)
        {
            meterno = mn;
            nounits = nu;
            unitrate = ur;
        }

        public void dispMsebBill()
        {
            Console.WriteLine("<================= This is MSEB Bill Section ===============>");
            Console.WriteLine("Meter number : " + meterno);
            Console.WriteLine("Number of units : " + nounits);
            Console.WriteLine("Unit rate : " + unitrate);
            Console.WriteLine("MESEB bill : " + (nounits * unitrate));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile m = new Mobile();
            m.addMobileBill(1, "Sadesh", "27/01/2024", "7020285895", 200, 1);
            m.dispMobBill();
            
            msebBill b = new msebBill();
            b.addMsebBill(15, 75, 10);
            b.dispMsebBill();
        }
    }
}
