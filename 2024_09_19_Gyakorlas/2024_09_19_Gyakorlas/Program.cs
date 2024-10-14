using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_19_Gyakorlas
{
    internal class Program
    {

        List<string> nevek = new List<string>()
        {
            "Farkas Máté",
            "Deák Zsombor",
            "Kakuk Ákos",
            "Kis Levente",
            "Varga Csaba",
            "Pálinkás Zoltán",
            "Détári Viktória",
            "Gebhardt Lilla",
            "Sebella Máté",
            "Zsidákovits Bálint",
            "Szabó Dániel"
        };


        static void Main(string[] args)
        {
            /*Hozzon létre egy struktúrát, amiben eltárolja a csoport neveit és mindenkinek generál egy 18 számjegyből álló kódot! Ezeket példányosítás során, adja is át!
             * A struktúrában legyenek a további mezők is:
             * Magasság, szemüveges, azonosito, jelszo
             * A példányosítás során fusson le egy véletlen generálás, ami megadja a magasság [160,190] között. Illetve véletlenszeren állítsa be, hogy szemüveges-e az illető.
             * Majd ugyan itt a példány elkészülése során, fusson le a struktúrában elkészített két függvény, az egyik eredménye az azonosító a másik jelszó!
             * Azonosito: minden páratlanadik karakter kis betuvel, szokoz nelkul! és a kód számjegyeinek összege majd @ckik.hu
             * jelszo: a kód kettesével vett értékének asci kódjából előállított betü! Ha 32-nél kisebb az érték, adjon hozzá 50-et!
             * Csináljon ToString metódust!    
             */


            Console.ReadLine();
        }

        struct Csop
        {
            //mezok
            public string nev, kod, azonosito, jelszo;
            public int magassag;
            public bool szemuvegese;

            //konstrukor
            public Csop(string nev, string kod)
            {
                Random r = new Random();
                this.nev = nev;
                magassag = r.Next(160, 191);
                //if (r.Next(2) == 0)
                //{
                //    szemuvegese = true;
                //}
                //else
                //{
                //    szemuvegese = false;
                //}
                szemuvegese = r.Next(2) == 0;
                this.kod = kod;
                azonosito = "";
                jelszo = "";

            }

            private string IdGeneralas(string szoveg)
            {
                string szokoznelkuli = Szokoztelenites(szoveg);
                string paratlanadikBetuk = Rovidites(szokoznelkuli);
                int szamjegyekosszege = SzamjegyekOsszeadasa(kod);
                return paratlanadikBetuk + szamjegyekosszege;



            }


            private int SzamjegyekOsszeadasa(string kod)
            {
                int sz = 0;
                for (int i = 0; i < kod.Length; i++)
                {
                    sz += kod[i] - 48;
                }

                return sz;
            }

            private string Szokoztelenites(string szoveg)
            {
                string ujnev = "";
                for (int i = 0; i < szoveg.Length; i++)
                {
                    if (szoveg[i] != ' ')
                    {
                        ujnev += szoveg[i];
                    }
                }
                return szoveg;
            }

            private string Rovidites(string ujnev)
            {
                string rovidnev = "";
                for (int i = 0; i < ujnev.Length; i++)
                {
                    if (i / 2 != 0)
                    {
                        rovidnev += ujnev[i];
                    }
                }
                return rovidnev.ToLower();
            }




            private string JelszoGeneralas()
            {

                string jelszo = "";
                for (int i = 0; i < kod.Length; i += 2)
                {
                    int a = Convert.ToInt32("" + kod[i] + kod[i + 1]);
                    jelszo += (char)a;

                }


                return jelszo;
            }




            public override string ToString()
            {
                return string.Format("{0} {1} {2} {3} {4} {5}", nev, kod, magassag, szemuvegese, azonosito, jelszo);
            }
        }
    }
}

