using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    class Abonnement
    {
        public Udgivelse Udgivelse { get; }
        public int Periode { get; set; }
        public bool Gentag { get; set; }
        public bool Tilbud { get; set; }

        public Abonnement(Udgivelse Udgivelse, int Periode, bool Gentag)
        {
            this.Udgivelse = Udgivelse;
            this.Periode = Periode;
            this.Gentag = Gentag;
            this.Tilbud = false;
        }

        public Abonnement(Udgivelse Udgivelse)
        {
            this.Udgivelse = Udgivelse;
            this.Periode = 1;
            this.Gentag = true;
            this.Tilbud = false;
        }

        public static List<Abonnement> AboTestData(Udgivelse u)
        {
            List<Abonnement> lAbo = new List<Abonnement>();
            lAbo.Add(new Abonnement(u, 10, true));

            return lAbo;
        }

        public static void ListAbo(List<Abonnement> lAbo)
        {
            foreach (Abonnement a in lAbo)
            {
                Console.WriteLine($"Navn: {a.Udgivelse.Navn}, Antal: {a.Periode}, Forny: {a.Gentag}");
            }
        }
    }
}
