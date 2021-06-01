using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    public abstract class Udgivelse
    {
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public double Pris { get; set; }
        public int Frekvens { get; set; }

        public Udgivelse(string navn, string beskrivelse)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
        }
    }
}
