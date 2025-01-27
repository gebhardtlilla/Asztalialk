using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_23_MOhegyei
{
    class Program
    {

        static List<Hegy> adatok = new List<Hegy>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat3();
            Feladat4();
            Feladat5();


            Console.ReadLine();
        }

        private static void Feladat5()
        {

            Console.Write("5.feladat");
                





            var legmagasabb = adatok.OrderByDescending(obj => obj.Magassagok).First();
            Console.WriteLine($"A legmagasabb hegycsúcs adatai:\n\tNév: {0} \n\tHegység: {1} \n\tMagasság: {2}m", legmagasabb.Hegycsucsok, legmagasabb.Hegysegek, legmagasabb.Magassagok);
        }

        private static void Feladat4()
        {
            Console.Write("4.feladat: ");
            double osszhegy = adatok.Sum(obj=>obj.Magassagok);
            Console.WriteLine("Hegycsúcsok átlagos magassága: {0} m", osszhegy/adatok.Count());
        }

        private static void Feladat3()
        {
            Console.Write("3.feladat: ");
            Console.WriteLine("Hegycsúcsok száma: {0} db" ,adatok.Count());


            
            //var hegyek = adatok
            //    .Select(obj => new
            //    {
            //        hegyekszama = obj.hegysegek.Count()
            //    });

            //foreach(var hegy in hegyek)
            //{
            //    Console.WriteLine(hegy.hegyekszama);
            //}
        }

        private static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("hegyekMO.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Hegy sv = new Hegy(sr.ReadLine());
                adatok.Add(sv);
            }
            sr.Close();


        }


    }
    
}
