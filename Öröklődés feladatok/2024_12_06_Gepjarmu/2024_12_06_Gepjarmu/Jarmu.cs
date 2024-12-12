using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_06_Gepjarmu
{
    internal abstract class Jarmu :IKisGepjarmu
    {
        protected int akt_sebesseg;
        private string rendszam;

        public Jarmu(int akt_sebesseg, string rendszam)
        {
            this.akt_sebesseg = akt_sebesseg;
            this.rendszam = rendszam;
        }

        public abstract bool GyorshajtottE(int sebessegkorlat);
        



        public override string ToString()
        {
            return $"{rendszam} -{akt_sebesseg} km/h";
        }
    }
}
