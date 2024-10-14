using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _2024_09_16_Struktura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya();
            k1.kor = 12;
            k1.fajta = "puli";

            Console.WriteLine(k1.ToString() + " " + k1.oltasokDatuma.First());

            Console.WriteLine("{0} {1} {2} {3}" , k1.fajta, k1.nev, k1.kor, k1.fajta, k1.kan);


            Kutya k2 = new Kutya(4, "Lex", "vizsla", true);
            Console.WriteLine(k2.ToString());
            Console.WriteLine("{0} {1} {2} {3}", k2.fajta, k2.nev, k2.kor, k2.fajta, k2.kan);


            Kutya k3 = k2;
            k3.fajta = "tacsko";
            Console.WriteLine(k3.ToString());



            List<Kutya> kutyak = new List<Kutya>();


            
            for (int i = 0; i < kutyak.Count; i++)
            {
                Console.WriteLine(kutyak[i].ToString());
            }



            int maxi  = 0;
            for (int i = 0;i < kutyak.Count;i++)
            {
                if (kutyak[i].kor > kutyak[maxi].kor)
                {
                    maxi = i;
                }
            }
            //Console.WriteLine("{0} {1} éves ", kutyak[maxi].nev, kutyak[maxi].kor);
            Kutya a = kutyak[maxi];
            Console.WriteLine("{0} {1} éves ", a.nev, a.kor);


            Console.ReadLine();

        }
    }



    struct Kutya
    {

        //Tulajdonság, mező, jellemző...
        public int kor;
        public string nev, fajta;
        public bool kan;
        public List<string> oltasokDatuma;



        //Konstruktor
        public Kutya(int kor, string nev,string fajta, bool kan)
        {
            this.kor = kor;
            this.nev = nev;
            this.fajta = fajta;
            this.kan = kan;
            oltasokDatuma = new List<string>() { "2022.05.04"};
            
           
        }


        //Metódus
        public string ToString()
        {
            return string.Format("");
        }


        //5mező kivülröl beküldeni
        // listaba eltarolni a kutyakat! Minden kutyanal toltsetek fel az oltas datumat + 3db datummal kutyankent



    }
}
