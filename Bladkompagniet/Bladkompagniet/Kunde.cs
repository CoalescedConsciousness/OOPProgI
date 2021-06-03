
using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    class Kunde : Person
    {
        public List<Udgivelse> Udgivelse = new List<Udgivelse>();
        public List<Abonnement> Abonnementer = new List<Abonnement>();

        public Kunde(string Adresse, string By, string Navn, int Post) : base(Adresse, By, Navn, Post)
        {
        }
        public Kunde() { }

        public static void ListKunder(List<Kunde> listKunde)
        {
            foreach (Kunde k in listKunde)
            {
                Console.WriteLine($"Navn: {k.Navn}, Adresse: {k.Adresse}, {k.Post}, {k.By}");
                
                if (k.Abonnementer.Count != 0)
                {
                    Console.WriteLine($"Har {k.Abonnementer.Count} abonnementer:");
                    for (int i = 0; i < k.Abonnementer.Count; i++)
                        Console.WriteLine($"{i+1}. Abonnement: {k.Abonnementer[i].Udgivelse.Navn}, Pris: {k.Abonnementer[i].Udgivelse.Pris}");
                }
            }
        }

        public void AddAbo(Abonnement a)
        {
            Abonnementer.Add(a);
        }


        public static List<Kunde> KundeTestData()
        {
            List<Kunde> lKunde = new List<Kunde>();
            lKunde.Add(new Kunde("Korsenstorp", "Galaca", "Ace", 1001));
            lKunde.Add(new Kunde { Adresse = "Jonathansgade", By = "Antonsbukser", Post = 2222, Navn = "Kasper" });
            
            return lKunde;
        }




    }
}
