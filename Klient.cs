using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Klient
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public int  godini { get; set; }
        public string destinacija { get; set; }

        public override string ToString()
        {
            return String.Format("Ime: {0} \nPrezime: {1} \nGodini: {2} \nDestinacija: {3}", ime, prezime, godini, destinacija);
        }
    }

    
}
