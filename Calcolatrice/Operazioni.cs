//Trasformare classi statiche in classi istanziabili
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
        private int risultato { get; set; };
        TipoOperazione Operando { get; set; }
        

        public Operazione(TipoOperazione operando)
        {
            /* this.NumElementi = nElementi;
             this.Cifre1 = cifre;*/
            this.Operando = operando;
        }

        public int Somma(Operazione addizione)
        {
            addizione = new Operazione(TipoOperazione.Addizione);
            addizione.
        }

        private int Differenza(Operazione sottrazione)
        {
            sottrazione = new Operazione(TipoOperazione.Sottrazione);
        }
        private int Prodotto(Operazione moltiplicazione)
        {
            moltiplicazione = new Operazione(TipoOperazione.Moltiplicazione);
        }
        private int Quota(Operazione divisione)
        {
            divisione = new Operazione(TipoOperazione.Divisione);
        }


    }
}
