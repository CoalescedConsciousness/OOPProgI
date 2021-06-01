using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    class Ugeblad : Udgivelse
    {
        public Ugeblad(string navn, string beskrivelse) : base (navn, beskrivelse)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
            Pris = 45.95;
            Frekvens = 7;
        }
    }
}
