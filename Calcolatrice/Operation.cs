using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    enum TipoOperazione
    {
        Addizione,
        Sottrazione,
        Moltiplicazione,
        Divisione
    }
    class Operazione
    {
        private int NumElementi { get; set; }
        TipoOperazione operazione;
        private int[] Cifre = new int[];
    }
}
