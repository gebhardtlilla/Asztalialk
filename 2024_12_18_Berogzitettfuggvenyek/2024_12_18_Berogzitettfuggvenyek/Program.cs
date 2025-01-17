using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_18_Berogzitettfuggvenyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzamosBeepitettFuggvenyek();

            Console.ReadLine();
        }

        private static void SzamosBeepitettFuggvenyek()
        {
            List<int>egeszek = new List<int>()
            {
                2,82,23,90,0,27,65,24,89
            };

            /*Kiiratas - foreach*/
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();


            /*Sum - Összegzés*/
            int sum = egeszek.Sum();
            Console.WriteLine("Összeg: "+ sum);

            /*Average - Átlag */
            double avg = egeszek.Average();
            Console.WriteLine("Átlag: "+avg);

            /*Min - Minimum*/
            double min = egeszek.Min();
            Console.WriteLine("Minimum érték: "+min);

            /*Max - Maximum*/
            int max = egeszek.Max();
            Console.WriteLine("Maximum érték: " + max);

            /*IndexOf - megadja az indexét a keresett elemnek
             Ha van benne az index értékével tér vissza,
            különben -1
             */
            int szam = 25;
            int index = egeszek.IndexOf(szam);
            Console.WriteLine($"Keresett elem: {szam} helye: " + $"{(index == -1 ? "Nincs benne ": ""+ index)}");

            /*Contains - Benne van-e a szerkezetben a keresett elem?*/
            bool vane = egeszek.Contains(szam);
            Console.WriteLine($"{(vane ? "Benne van a ": "Nincs benne a ")} {szam}");

            /*Remove - törli az első elemet, amit megadunk, és visszatér a tölés eredményével.*/
            if(egeszek.Remove(szam))
            {
                foreach (int a in egeszek) Console.Write(a + " ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Nincs a listában a törlendő elem ({szam})");
            }

            /*RemoveAt - index alapján törli az elemet*/
            egeszek.RemoveAt(0);

            /*Sort - rendezés*/
            egeszek.Sort();
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            Console.WriteLine("Első elem: " + egeszek.First());
            Console.WriteLine("Utolsó elem: " + egeszek.Last());

            //Elem hozzáadása megadott indexre
            egeszek.Insert(1, 2);
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            //InsertRange - Listához lista fűzése
            List<int> ujlista = new List<int>() {1,2,3};
            ujlista.InsertRange(0, egeszek);
            foreach (int a in ujlista) Console.Write(a + " ");
            Console.WriteLine();


        }
    }
}
