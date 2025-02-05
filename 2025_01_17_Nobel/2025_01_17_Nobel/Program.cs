using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_17_Nobel
{
    internal class Program
    {
        static List<Nobel> adatok = new List<Nobel>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();

            Console.ReadLine();
        }

        private static void Feladat8()
        {
            Console.WriteLine("8.feladat: ");
            StreamWriter w = new StreamWriter("orvosi.txt");
            
                var adatok2 = adatok
                    //.OrderBy(obj => obj.ev)
                    .Select(obj => new
                    {
                        evek=obj.ev,
                        knevek= obj.keresztnev,
                        vnevek = obj.vezeteknev
                    }); 
                foreach(var adat in adatok2)
                {
                    w.WriteLine("{0}: {1} {2}", adat.evek, adat.knevek, adat.vnevek);
                }
            w.Close();

        }

        private static void Feladat7()
        {
            Console.WriteLine("7.feladat: ");
            var dijak = adatok
                .GroupBy(obj => obj.tipus)
                .Select(obj => new
                {
                    tipusok = obj.Key,
                    tipusokszama = obj.Count()
                });

            foreach(var dij in dijak )
            {
                Console.WriteLine("\t{0} {1}db" ,dij.tipusok, dij.tipusokszama);
            }
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.feladat: ");
            var curie = adatok
                .Where(obj => obj.vezeteknev.Contains("Curie"))
                .Select(obj => new
                {
                    evek= obj.ev,
                    keresztnevek = obj.keresztnev,
                    vezeteknevek = obj.vezeteknev,
                    tipusok = obj.tipus
                });

            foreach( var ember in curie)
            {
                Console.WriteLine(ember.evek + ": " + ember.keresztnevek + " " + ember.vezeteknevek + "(" + ember.tipusok+ ")");
            }

        }


        private static void Feladat5()
        {
            Console.WriteLine("5.feladat: ");
            var bekenobeldijak = adatok
                .Where(obj => obj.ev > 1989 && obj.tipus == "béke" && obj.vezeteknev == "")
                //.GroupBy(obj => obj.tipus)
                .Select(obj => new
                {
                    keresztn = obj.keresztnev,
                    vezetkn = obj.vezeteknev,
                    ev2 = obj.ev
                });

            foreach (var beke in bekenobeldijak)
            {
                Console.WriteLine(beke.ev2 +": "+ beke.keresztn +" "+ beke.vezetkn);
            }


        }


        private static void Feladat4()
        {
            Console.Write("4.feladat: ");

            var irodalmiak = adatok
                .Where(obj => obj.ev == 2017 && obj.tipus == "irodalmi")
                .Select(obj => new
                {
                    vezetek = obj.vezeteknev,
                    kereszt = obj.keresztnev
                });

            foreach (var i in irodalmiak)
            {
                Console.WriteLine(i.kereszt +" "+i.vezetek);
            }

        }

        private static void Feladat3()
        {
            Console.Write("3.feladat: ");

            var eredmenyek = adatok
                .Where(obj => obj.vezeteknev == "McDonald" && obj.keresztnev == "Arthur B.")
                .Select(obj => new
                {
                    tipus2 = obj.tipus
                });


            foreach (var eredmeny in eredmenyek)
            {
                Console.WriteLine(eredmeny.tipus2);
            }
            

        }

       private static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("nobel.csv");
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                Nobel sv = new Nobel(sr.ReadLine());
                adatok.Add(sv);
            }
            sr.Close();

                
        }
    }
}
