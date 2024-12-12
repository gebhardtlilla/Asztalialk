using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_11_04
{
    internal class Program
    {

        static List<Haromszog>haromszogek = new List<Haromszog>();
        static void Main(string[] args)
        {

            Feladat1();
            Feladat2();
            Feladat3();
            
            Console.ReadLine();
        }

        static void Feladat3()
        {
            bool van_e = VanE();
        }


        static bool VanE()
        {
            bool van_e = false;
            int i = 0;
            while(i<haromszogek.Count && !haromszogek[i].SzabalyosE())
            {
                i++;
            }
            if (i < haromszogek.Count)
            {
                van_e=true;
            }

            return van_e;
        }


        static void Feladat2()
        {
            int index = MaxTeruletuHromszogIndexe();
            Haromszog sv = haromszogek[index];
            Console.WriteLine("Max teruletu haromszog oldalai: a= {0} b={1}  c={2}", sv.A, sv.B, sv.C);

        }


        static int MaxTeruletuHromszogIndexe()
        {
            int maxi = 0;
            for (int i = 1; i < haromszogek.Count; i++)
            {
                if (haromszogek[i].SzerkezthetoE() && haromszogek[i].Terulet() > haromszogek[maxi].Terulet())
                {
                    maxi = i;
                }
            }

            return maxi;
        }


























        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("haromszogek.txt");

            string sor2 = f.ReadLine();
            while (!f.EndOfStream)
            {
                string sor = f.ReadLine();
                Haromszog sv = new Haromszog(sor);
                haromszogek.Add(sv);
                //haromszogek.Add(new Haromszog(f.ReaLine()));
            }


            f.Close();
        }


        static void Feladat1()
        {
            int db = Szerkeszthetodb();
            Console.WriteLine(db);
        }

        static int Szerkeszthetodb()
        {
            int db = 0;
            for (int i = 0; i < haromszogek.Count;i++)
            {
                if (!haromszogek[i].SzerkezthetoE() == true)
                {
                    db++;
                }
            }

            return db;


        }




    }
}
