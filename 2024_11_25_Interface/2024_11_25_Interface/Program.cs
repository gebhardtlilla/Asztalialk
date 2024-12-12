using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_25_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //polimorfizmus - többalakúség. Egy ostályt több, különböző példányokat tud tárolni. (Ha közös az ős)
            IFenykepezo f1 = new Osztaly();
            IFenykepezo f2 = new Mobil();

            if(f1.GetType() == typeof(Osztaly))
            {
                f1.FenykepetKeszit(3);
            }

            Console.ReadLine();

        }
    }
}
