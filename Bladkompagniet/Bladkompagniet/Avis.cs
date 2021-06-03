using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    class Avis : Udgivelse
    {
        public Avis(string navn, string beskrivelse)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
            Pris = 35.95;
            Frekvens = 1;
        }

        public static List<Avis> AvisTestData()
        {
            List<Avis> lAvis = new List<Avis>();
            lAvis.Add(new Avis("Ekstra Prut", "Offentlig trusler"));

            return lAvis;
        }
        public static void ListAviser(List<Avis> listAvis)
        {
            foreach (Avis a in listAvis)
            {
                Console.WriteLine($"Navn: {a.Navn}, Beskrivelse: {a.Beskrivelse}, Pris: {a.Pris}, Frekvens: {a.Frekvens}");
            }
        }

        public void GetTilbud(Tilbud t)
        {
            if (DateTime.Now > t.fra && DateTime.Now < t.til)
            {
                Console.WriteLine(Pris);
                Pris *= 1 - (t.amount / 100);
                Pris = Math.Round(Pris, 2);
                Console.WriteLine(Pris);
            }
            else
                Pris = Pris;
        }
    }
}
