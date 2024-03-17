using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Program_11
{
    class Weight
    {
        public int KG;
        public int GM;

        public void initWeight(int kg,int gm)
        {
            this.KG = kg;
            this.GM = gm;
        }

        public void dispWeight()
        {
            Console.WriteLine("Weight in KG is : " + KG);
            Console.WriteLine("Weight in GM is : " + GM);
        }

        public static Weight operator + (Weight w1, Weight w2)
        {
            Weight w = new Weight();
            w.GM = w1.GM + w2.GM;

            if (w.GM > 1000)
            {
                w.KG = w.GM / 1000;
                w.GM = w.GM % 1000;
                
            }
            w.KG = w1.KG + w2.KG + w.KG; 
            return w;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Original Weight==========");
            Weight w = new Weight();
            w.initWeight(10, 800);
            w.dispWeight();

            Weight w2 = new Weight();
            w2.initWeight(15, 800);
            w2.dispWeight();

            Console.WriteLine("==============After Addition==========");
            Weight w3 = w + w2;
            w3.dispWeight();
        }
    }
}
