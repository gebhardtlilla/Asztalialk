using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_17_Nobel
{
    internal class Nobel
    {
        public int ev { get; set; }
        public string tipus { get; set; }
        public string keresztnev { get; set; }
        public string vezeteknev { get; set; }
       
        public Nobel(string sor)
        {
            string[] st = sor.Split(';');
            ev= Convert.ToInt32(st[0]);
            tipus = st[1];
            keresztnev = st[2];
            vezeteknev = st[3];

        }
    }
}
