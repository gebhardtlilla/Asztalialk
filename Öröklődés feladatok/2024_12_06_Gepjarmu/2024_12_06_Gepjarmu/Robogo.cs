using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_06_Gepjarmu
{
    internal class Robogo:Jarmu, IKisGepjarmu
    {
        public int maxsebesseg;


        public Robogo(string rendszam, int sebesseg, int max_sebesseg):base(sebesseg, rendszam)
        {
            
            this.maxsebesseg = max_sebesseg;

        }

        public override bool GyorshajtottE(int sbk)
        {
            return akt_sebesseg > sbk;
        }

        public bool HaladhatItt(int sebesseg)
        {
            return maxsebesseg <= sebesseg;
        }

        public override string ToString()
        {
            return "Robogo: "+ base.ToString(); //Az ősosztály tostring metódus használata
        }

       

    }
}
