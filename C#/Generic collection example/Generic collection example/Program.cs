using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collection_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("Apple");
            s.Push("Banana");
            s.Push("Mango");
            s.Push("Orange");

            Console.WriteLine("Stack genric example ======>");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            Console.WriteLine("Queue generic example ======>");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            List<double> a = new List<double>();
            a.Add(11.11);
            a.Add(22.22);
            a.Add(33.33);
            a.Add(44.44);

            Console.WriteLine("ArrayList genric example =====>");
            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            a.Insert(1,55.55);
            a.Remove(22.22);
            a.RemoveAt(2);
            Console.WriteLine("Count is :" + a.Count);
            Console.WriteLine("ArrayList genric after =======>");
            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
