using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_16_Mukorcsolya
{
    internal class Program
    {
        static List<Versenyzo> donto = new List<Versenyzo>();
        static List<Versenyzo> rovidprogram = new List<Versenyzo>();
        static void Main(string[] args)
        {
            donto = Fajlbeolvasas("donto.csv");
            rovidprogram = Fajlbeolvasas("rovidprogram.csv");

            Feladat2();
            Feladat3();
            Feladat5_6();
            Feladat7();
            Feladat9();
           // Kiiratas();
           

            Console.ReadLine();
        }

        private static void Feladat9()
        {
            //var result = collection.Max(x => x.Price);

            //var legjobb = donto
            //    .GroupBy(v=>v.orszag)
            //    .Max(x=> x.OsszpontSzam)

            Console.WriteLine("9.feladat");
            var orszagLista = donto
                .GroupBy(versenyzo => versenyzo.orszag)
                .Where(obj => obj.Count() > 1)
                .Select(obj => new
                {
                    orszag = obj.Key,
                    //legjobb = obj.ToList().Find(c=> c.Osszpont == obj.Max(x=>Osszpont))
                }

                );

            foreach (var orszag in orszagLista)
            {
                //Console.WriteLine("{0}: {1} versenyzo", orszag.orszag, orszag.legjobb.nev );
            }

        }

        private static void Feladat7()
        {
            Console.WriteLine("7.feladat");
            var orszagLista = donto
                .GroupBy(versenyzo => versenyzo.orszag)
                .Where(donto => donto.Count() > 1)
                .Select(csoport => new
                {
                    orszag = csoport.Key,
                    szam = csoport.Count()
                }

                );

            foreach (var orszag in orszagLista)
            {
                Console.WriteLine("{0}: {1} versenyzo", orszag.orszag, orszag.szam);
            }
        }

        private static void Feladat5_6()
        {
            Console.WriteLine("5. feladat");
            Console.Write($"\tKérem a versenyző nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("6. feladat");
            Console.WriteLine($"\tA versenyző összpontszáma: {OsszpontSzam(nev)}");
        }

        private static double OsszpontSzam(string nev)
        {
            var versenyzoR = rovidprogram.Find(x=>x.nev == nev);
            if (versenyzoR == null) return -1;
            var versenyzoD = donto.Find(x=>x.nev == nev);
            if (versenyzoD == null) return versenyzoR.Osszpont;
            return versenyzoR.Osszpont + versenyzoD.Osszpont;
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. Feladat");
            bool vanEMagyar = donto.Any(x => x.orszag == "HUN");
            if(vanEMagyar )
                Console.WriteLine("A magyar versenyző bejutott a kűrbe");
            else
                Console.WriteLine("A magyar versenyző nem jutott be a kűrbe");
        }

        private static void Feladat2()
        {
            Console.WriteLine("2. Feladat");
            Console.WriteLine($"\tA rövid programban {rovidprogram.Count} induló volt.");
        }

        private static List<Versenyzo> Fajlbeolvasas(string path)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            StreamReader sr = new StreamReader(path);
            sr.ReadLine();
            
            while (!sr.EndOfStream)
            {
                Versenyzo v = new Versenyzo(sr.ReadLine());
                versenyzok.Add(v);
            }

            sr.Close();
            return versenyzok;
        }

        //private static void Kiiratas()
        //{
        //    var sorbarendezes = rovidprogram
        //        .Select(x => new
        //        {
        //            nev = x.nev,
        //            orszag = x.orszag,
        //            pontsz = OsszpontSzam(x.nev)
                    


        //        })
        //        .OrderBy(x => x.pontsz);

            



        //    StreamWriter w = new StreamWriter("vegeredmeny.csv");
        //    List<string> adatok = new List<string>();

        //    //foreach (var orszag in orszagLista)
        //    //{
        //    //    Console.WriteLine("{0}: {1} versenyzo", orszag.orszag, orszag.legjobb.nev);
        //    //}

        //    int i = 0;
        //    foreach ( var adat in sorbarendezes)
        //    {
        //        adatok[i]= adat.nev +";" + adat.orszag+ ";" + adat.pontsz;
        //        i++;
        //    }

        //    for (int j = 0; j < donto.Count; j++)
        //    {
        //        w.WriteLine(adatok[j]);

        //    }

        //    w.Close();
        //}

    }


}
