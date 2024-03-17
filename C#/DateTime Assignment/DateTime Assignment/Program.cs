using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Medicine
    {
        public int medicineId;
        public int batchNo;
        public string medicineName;
        public string mfgName;
        public double price;
        public int expairyDate;

        public Medicine(int mId, int bNo, string mName, string mfName, double pr, int eDate)
        {
            this.medicineId = mId;
            this.batchNo = bNo;
            this.medicineName = mName;
            this.mfgName = mfName;
            this.price = pr;
            this.expairyDate = eDate;
        }

        public void dispMedicine()
        {
            Console.WriteLine("Medicine id is : "+ medicineId);
            Console.WriteLine("Batch no. is : " + batchNo);
            Console.WriteLine("Medicine name is : " + medicineName);
            Console.WriteLine("Mfg name is : " + mfgName);
            Console.WriteLine("Price is : " + price);
            Console.WriteLine("Expiary is : " + expairyDate);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int mid, bn;
            string mn, mfn;
            double pr;
            int dn = DateTime
            int ed = DateTime.Now.AddMonths(1).Month;

            List<Medicine> l = new List<Medicine>();

            for(int i=0; i < 1; i++)
            {
                Console.Write("Enter medicine id : ");
                mid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter batch number : ");
                bn = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter medicine name : ");
                mn = Console.ReadLine();
                Console.Write("Enter mfg name : ");
                mfn = Console.ReadLine();
                Console.Write("Enter price : ");
                pr = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter expiary date :");
                ed = Convert.ToInt32(Console.ReadLine());
                l.Add(new Medicine(mid, bn, mn, mfn, pr, ed));
            }

            for(int i = 0; i < 1; i++)
            {
                if (ed == dn)
                {
                    Console.WriteLine("These Medicines will be expired next month :");
                    l[i].dispMedicine();
                }
            }
        }
    }
}
