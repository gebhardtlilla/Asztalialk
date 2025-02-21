﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_16_Ismetles_Structura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya(); //struktúra egy példánya
            k1.kor = 12;
            k1.fajta = "puli";

            //Console.WriteLine("{0} {1} {2} {3}", k1.kor, k1.nev, k1.fajta, k1.kan);
            Console.WriteLine(k1.ToString()+" "+k1.oltasokDatuma);

            Kutya k2 = new Kutya(4, "Lex", "vizsla",true);

            //Console.WriteLine("{0} {1} {2} {3}", k2.kor, k2.nev, k2.fajta, k2.kan);
            //Console.WriteLine(k2.ToString());
            Console.WriteLine(k2.ToString() + " " + k2.oltasokDatuma);

            Kutya k3 = k2;
            k3.fajta = "tacskó";
            Console.WriteLine(k3.ToString());

            // Listába a kutyákat! Minden kutyánál töltse fel az oltás dátumát +3 db dátummal, kutyánként!
            


            Console.ReadLine();
        }
    }

    struct Kutya
    {
        // Tulajdonság, mező, jellemző, ...
        public int kor;
        public string nev, fajta;
        public bool kan;
        public List<string> oltasokDatuma;

        //Konstruktor

        public Kutya(int kor, string nev, string fajta, bool kan)
        {
            this.kor = kor;
            this.nev = nev;
            this.fajta = fajta;
            this.kan = kan;
            oltasokDatuma = new List<string>() { "2022.05.04" };
        }

        //Metódus
        public override string ToString()
        { 
            //return kor+" "+nev+" "+fajta+" "+kan;
            return string.Format("\nkor: {0} \nnev: {1} \nfajta: {2} \nkan: {3}", kor,nev,fajta,kan);
        }
    }
}
