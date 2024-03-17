using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_14
{

    public class books {
        private int bookid;
        private string bookname;
        private string authername;
        private double price;

        public void addbook(int bi, string bn, string an, double p)
        {
            bookid = bi; bookname = bn; authername = an; price = p; 
        }

        public void dispbook()
        {
            Console.WriteLine("Bookid is " + bookid);
            Console.WriteLine("Book name is " + bookname);
            Console.WriteLine("Auther name is " + authername);
            Console.WriteLine("Price is " + price);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            books a = new books();
            a.addbook(1, "ABC", "XYZ", 200);
            a.dispbook();

            books b = new books();
            a.addbook(2, "XYZ", "ABC", 400);
            a.dispbook();
        }
    }
}
