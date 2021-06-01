using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    class Avis : Udgivelse
    {
        public Avis(string navn, string beskrivelse) : base(navn, beskrivelse)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
            Pris = 35.95;
            Frekvens = 1;
        }
    }
}
