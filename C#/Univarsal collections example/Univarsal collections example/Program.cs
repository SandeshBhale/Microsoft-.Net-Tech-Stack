using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Univarsal_collections_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push("Apple");
            s.Push(22.33);
            s.Push("Mango");

            Console.WriteLine("Stack Universal ==========>");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("Apple");
            q.Enqueue(22.33);
            q.Enqueue("Mango");

            Console.WriteLine("Queue Universal ==========>");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add("Apple");
            a.Add(22.33);
            a.Add("Mango");

            Console.WriteLine("ArrayList Universal =======>");
            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            a.Insert(2, "Orange");
            a.Remove("Mango");
            a.RemoveAt(3);
            a.Contains("Apple");
            Console.WriteLine("Count is : " + a.Count);
            //a.Clear();

            Console.WriteLine("ArrayList Universal =======>");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
