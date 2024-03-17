using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Program_15
{
    class book
    {
        private int bookid;
        private string bookname;
        private string auther;
        private double price;

        public void addBook(int bid,string bname,string aname,double pr)
        {
            bookid = bid;
            bookname = bname;
            auther = aname;
            price = pr;
        }

        public void dispBook()
        {
            if (price > 2000)
            {
                Console.WriteLine("Book id : " + bookid);
                Console.WriteLine("Book name : " + bookname);
                Console.WriteLine("Auther name : " + auther);
                Console.WriteLine("Price : " + price);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            book[] b = new book[5];

            int bid;
            string bname, aname;
            double price=0;

            for(int i = 0; i < 5; i++)
            {
                    Console.Write("Enter book id ");
                    bid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter book name ");
                    bname = Console.ReadLine();
                    Console.Write("Enter auther name ");
                    aname = Console.ReadLine();
                    Console.Write("Enter Price ");
                    price = Convert.ToDouble(Console.ReadLine());

                    b[i] = new book();
                    b[i].addBook(bid, bname, aname, price);    
            }

            for(int i = 0; i < 5; i++)
            {
                    b[i].dispBook();  
            }

        }
    }
}
