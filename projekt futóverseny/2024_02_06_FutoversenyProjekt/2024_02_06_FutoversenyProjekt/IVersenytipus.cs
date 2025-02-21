using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_FutoversenyProjekt
{
    internal interface IVersenytipus
    {
        string ID { get; set; }
        int Hossz { get; set; }
        DateTime Datum { get; set; }
    }
}
