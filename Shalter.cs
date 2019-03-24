using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Shalter
    {
        public int usluzeniKlienti { get; set; }
        public List<Klient> klienti { get; set; }

        public long  promet { get; set; }

        public Shalter ()
        {
            usluzeniKlienti = 0;
            klienti = new List<Klient>();
            promet = 0;

        }

        public void dodadiKlient(Klient k)
        {
            klienti.Add(k);
            usluzeniKlienti++;
            promet += k.destinacija.Length * 2000;
        }

    }
}
