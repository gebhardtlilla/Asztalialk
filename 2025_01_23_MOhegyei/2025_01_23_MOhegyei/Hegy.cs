using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_23_MOhegyei
{
    internal class Hegy
    {
        public string Hegycsucsok { get; set; }
        public string Hegysegek { get; set; }
        public int Magassagok { get; set; }

        public Hegy(string sor)
        {
            string[] st = sor.Split(';');
            Hegycsucsok = st[0];
            Hegysegek = st[1];
            Magassagok = Convert.ToInt32(st[2]);
        }

    }
}
