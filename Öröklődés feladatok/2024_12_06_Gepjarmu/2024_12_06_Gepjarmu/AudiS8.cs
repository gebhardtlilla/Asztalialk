using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_06_Gepjarmu
{
    internal class AudiS8: Jarmu
    {
        public bool lezerblokkolo;

        public AudiS8(bool lezerblokkolo, int akt_sebesseg, string rendszam): base(akt_sebesseg, rendszam)
        {
            this.lezerblokkolo = lezerblokkolo;
        }

        public bool GyorshajtottE(int sebessegKorlat)
        {
            return akt_sebesseg > sebessegKorlat || lezerblokkolo;
        }
    }
}
