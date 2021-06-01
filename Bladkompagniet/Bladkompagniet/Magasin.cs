using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    class Magasin : Udgivelse
    {
        public Magasin(string navn, string beskrivelse) : base(navn, beskrivelse)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
            Pris = 55.95;
            Frekvens = 60;
        }
    }
}
