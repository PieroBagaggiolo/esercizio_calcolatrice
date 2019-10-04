using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operazioni;

namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int continua;
            do
            {
                Console.WriteLine("Decidi il tipo di operazione da eseguire: \n - 1 ADDIZIONE \n - 2 SOTTRAZIONE \n - 3 MOLTIPLICAZIONE \n  - 4 DIVISIONE");
                int scelta = Int32.Parse(Console.ReadLine());
                if (scelta > 4)
                {
                    do
                    {
                        Console.WriteLine("Opzione non valida. Scegli da 1 a 4");
                        scelta = Int32.Parse(Console.ReadLine());
                    }
                    while (scelta > 4);
                }

                Console.WriteLine("Quante cifre vuoi inserire?");
                int n = Int32.Parse(Console.ReadLine());
                if (scelta == 1)
                {
                    int sum = Calculator.Add(n);

                    Console.WriteLine("Il risultato della somma è: " + sum + "\n");

                }
                if (scelta == 2)
                {
                    int sot = Calculator.Min(n);

                    Console.WriteLine("Il risultato della sottrazione è: " + sot + "\n");
                }
                if (scelta == 3)
                {
                    int mol = Calculator.Prod(n);

                    Console.WriteLine("Il risultato della moltiplicazione è: " + mol + "\n");
                }
                if (scelta == 4)
                {
                    double quo = Calculator.Quota(n);

                    Console.WriteLine("Il risultato della divisione è: " + quo + "\n");
                }
                

                Console.WriteLine("Se vuoi terminare premi 0, \n per continuare premi qualsiasi altro tasto.");
                continua = Int32.Parse(Console.ReadLine());
            }
            while (continua !=0);
        }
    }
}
