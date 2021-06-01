
using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    class Kunde : Person
    {
        public int Kundenummer { get; }
        public List<Abonnement> abonnementer = new List<Abonnement>();

        public Kunde(string Adresse, string By, string Navn, int Post, int Kundenummer) : base(Adresse, By, Navn, Post)
        {
            this.Kundenummer = Kundenummer;
        }

        
    }
}
