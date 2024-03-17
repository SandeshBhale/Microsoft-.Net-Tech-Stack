using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1
{
    class Docter
    {
        public int drId { get; set; }

        public string drName { get; set; }

        public string cityName { get; set; }

        public string speciality { get; set; }

        public double firstCharge { get; set; }

        public double secondCharge { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Docter d = new Docter();

            List<Docter> lst = new List<Docter>();

            // GP = Genral phy , Cardiologist = CL , Dermatologist = DL , Gastroenterologists = GL 

            lst.Add(new Docter() { drId = 1, drName = "Mahesh",cityName = "Pune", speciality = "GP", firstCharge = 300, secondCharge = 200 });
            lst.Add(new Docter() { drId = 1, drName = "Ramesh",cityName = "Parbhani", speciality = "GP", firstCharge = 200, secondCharge = 100 });
            lst.Add(new Docter() { drId = 1, drName = "Kalpesh",cityName = "Pune", speciality = "CL", firstCharge = 800, secondCharge = 500 });
            lst.Add(new Docter() { drId = 1, drName = "Yadnesh",cityName = "PCMC", speciality = "CL", firstCharge = 1000, secondCharge = 800 });
            lst.Add(new Docter() { drId = 1, drName = "Yogesh",cityName = "Parbhani", speciality = "CL", firstCharge = 500, secondCharge = 300 });
            lst.Add(new Docter() { drId = 1, drName = "Ritesh",cityName = "Pune", speciality = "DL", firstCharge = 300, secondCharge = 200 });
            lst.Add(new Docter() { drId = 1, drName = "Pritesh",cityName = "Parbhani", speciality = "DL", firstCharge = 200, secondCharge = 100 });
            lst.Add(new Docter() { drId = 1, drName = "Aasish",cityName = "PCMC", speciality = "DL", firstCharge = 500, secondCharge = 250 });
            lst.Add(new Docter() { drId = 1, drName = "Kavish",cityName = "Pune", speciality = "GL", firstCharge = 600, secondCharge = 500 });
            lst.Add(new Docter() { drId = 1, drName = "Kashish",cityName = "Parbhani", speciality = "GP", firstCharge = 400, secondCharge = 200 });

            var f = from t in lst where t.cityName == "Pune" select t;
            Console.WriteLine("\nDocters form Pune city are ========>");
            foreach(var temp in f)
            {
                Console.WriteLine(temp.drName);
            }

            var f2 = from t in lst where t.cityName == "Pune" && t.speciality == "CL" select t;
            Console.WriteLine("\nDocters from Pune city having speciality in Cardiology are =====>");
            foreach(var temp in f2)
            {
                Console.WriteLine(temp.drName + ":city:" + temp.cityName + ":speciality:" + temp.speciality);
            }

            var f3 = from t in lst where t.firstCharge - t.secondCharge == 100 select t;
            Console.WriteLine("\nDoctors charging fees gap of 100 between first and second visit are ==== >");
            foreach(var temp in f3)
            {
                Console.WriteLine(temp.drName + ":first charge:"+temp.firstCharge+":second charge:" + temp.secondCharge);
            }

            var f4 = from t in lst group t by t.cityName into g select new {city = g.Key,cnt = g.Count()};
            Console.WriteLine("\nCount of docters by city is =====>");
            foreach(var temp in f4)
            {
                Console.WriteLine(temp.city + " : " + temp.cnt);
            }

            var f5 = from t in lst where t.speciality=="CL" group d by t.cityName into g select new { city = g.Key, cnt = g.Count() };
            Console.WriteLine("\nCount of Cardilogist from every city is ====>");
            foreach(var temp in f5)
            {
                Console.WriteLine(temp.city+" : "+temp.cnt);
            }

            var f6 = from t in lst group t by t.cityName into g select new { city = g.Key, avg = g.Average(p=>p.firstCharge) };
            Console.WriteLine("\nCity name and averge of first visit charge ===>");
            foreach (var temp in f6)
            {
                Console.WriteLine(temp.city + " : " + temp.avg);
            }

            var f7 = from t in lst group t by t.cityName into g select new { city = g.Key, avg = g.Average(p => p.secondCharge) };
            Console.WriteLine("\nCity name and averge of second visit charge ===>");
            foreach (var temp in f7)
            {
                Console.WriteLine(temp.city + " : " + temp.avg);
            }
        }
    }
}
