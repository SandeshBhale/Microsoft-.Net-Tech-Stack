using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_hadling_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;

                Console.Write("Enter Number : ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number : ");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;

                Console.WriteLine("Division is : " + c);
            }

            catch (DivideByZeroException dz)
            {
                Console.WriteLine("Divide by Zero Exception occured");
                Console.WriteLine(dz);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception in above program is ");
                Console.WriteLine(ex);
            }

            finally
            {
                Console.WriteLine("==> Finally block which is executed always regardless of exception <==");
            }
        }
    }
}
