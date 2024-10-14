using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_11_Osztaly_Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hozzon létre egy Dolgozo nevu osztalyt.
             *  - Név (konstruktorban, lekérdezhető, nem módosítható)
             *  - aktív (konstruktorban - opcionális True, lekérdezhető)
             *  - évek, amióta a cégnél dolgozik ( konstruktoban - opcionális 0, lekérdezhető)
             * 
             * Metódusok:
             *  - FV: Módosíthatja az aktív állapotot!
             *  - FV: Növeli eggyel az évek számát!
             *  - FV: ToString
             *  
             *  Töltsön fel egy tömböt dolgozókkal! Majd jelenítse meg őket!
             */


            Console.ReadLine();
        }
    }


    class Dolgozo
    {
        private string nev;
        private bool aktiv;
        private int evek;


        public Dolgozo(string nev, bool aktiv = true, int evek = 0)
        {
            this.nev = nev;
            this.aktiv = aktiv;
            this.evek = evek;
        }


        public string Nev
        {
            get
            {
                return nev;
            }
            
        }

        public bool Aktiv
        {
            get
            {
                return aktiv;
            }

        }




    }
        
}
