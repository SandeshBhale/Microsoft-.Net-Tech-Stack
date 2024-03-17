using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_polymorphism_Ex1
{
    class Animal
    {
        public virtual void Display()
        {
            Console.WriteLine("Deafault animal ...!");
        }
    }

    class Dog : Animal
    {
        public override void Display()
        {
            Console.WriteLine("Dog called ...!");
        }
    }

    class Cat : Animal
    {
        public override void Display()
        {
            Console.WriteLine("Cat called ...!");
        }
    }

    class Rat : Animal
    {
        public override void Display()
        {
            Console.WriteLine("Rat called ...!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine("Enter 1 for calling Dog \nEnter 2 for calling Cat \nEnter 3 for calling Rat");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    a = new Dog();
                    break;
                case 2:
                    a = new Cat();
                    break;
                case 3:
                    a = new Rat();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            a.Display();
        }
    }
}
