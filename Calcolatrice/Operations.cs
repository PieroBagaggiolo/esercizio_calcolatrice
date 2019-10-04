using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operazioni
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
        private int[] Cifre = new int[];
        TipoOperazione operazione;
    }

    public Somma()
    {
        
    }

    public static class Calculator
    {
        public static int Add(int quantita)
        {
            
            int[] valori = new int[quantita];
            int ris = 0;
            for (int t = 0; t < quantita; t++)
            {
                Console.WriteLine("Inserisci il " + (t + 1) + " valore:");
                int c = Int32.Parse(Console.ReadLine());
                valori[t] = c;
                ris = ris + valori[t];
            }
            return ris;
        }
        public static int Min(int quantita)
        {

            int[] valori = new int[quantita];
            int rid = 0;
            for (int t = 0; t < quantita; t++)
            {
                Console.WriteLine("Inserisci il " + (t + 1) + " valore:");
                int c = Int32.Parse(Console.ReadLine());
                valori[t] = c;
            }
            rid = valori[0];
            for (int i = 1; i < quantita; i++)
            {
                rid = rid - valori[i];
            }
            return rid;
        }
        public static int Prod(int quantita)
        {
            int[] valori = new int[quantita];
            int prod = 0;
            for (int t = 0; t < quantita; t++)
            {
                Console.WriteLine("Inserisci il " + (t + 1) + " valore:");
                int c = Int32.Parse(Console.ReadLine());
                valori[t] = c;
            }
            prod = valori[0];
            for(int i = 1; i < quantita; i++)
            {
                prod = prod * valori[i];
            }
            return prod;
        }
        public static double Quota(int quantita)
        {
            int[] valori = new int[quantita];
            double quo = 0;
            Console.WriteLine("Inserisci il 1 valore:");
            int c = Int32.Parse(Console.ReadLine());
            valori[0] = c;
            for (int t = 1; t < quantita; t++)
            {
                Console.WriteLine("Inserisci il " + (t + 1) + " valore:");
                c = Int32.Parse(Console.ReadLine());
                valori[t] = c;
                while (valori[t] == 0)
                {
                    quo = 0;
                    Console.WriteLine("Operazione impossibile: il divisore non può essere pari a 0 \n Inserisci un'altra cifra");
                    c = Int32.Parse(Console.ReadLine());
                    valori[t] = c;
                }

            }
            quo = valori[0];
            
            for (int i = 1; i < quantita; i++)
            {
                
                 quo = (double)quo / valori[i];
          
            }
            return quo;
        }

    }
}
