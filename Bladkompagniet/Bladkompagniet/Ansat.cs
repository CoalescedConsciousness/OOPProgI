using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    class Ansat : Person
    {
        public DateTime AnsatDato { get; set; }
        public int AnsatID { get; }
        enum Stilling
        {
            Journalist,
            Trykker,
            Rengøring,
            Kantine,
            Pedel,
            Direktør,
        }

        public Ansat(DateTime AnsatDato, int AnsatID, string Adresse, string By, string Navn, int Post) : base (Adresse, By, Navn, Post)
        {
            this.AnsatDato = AnsatDato;
            this.AnsatID = AnsatID;
        }


    }
}
