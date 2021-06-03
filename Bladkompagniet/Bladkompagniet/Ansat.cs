using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    public class Ansat : Person
    {
        public DateTime AnsatDato { get; set; }
        public int AnsatID { get; }
        public string StillingID { get; set; }
        enum Stilling
        {
            Journalist,
            Trykker,
            Rengøring,
            Kantine,
            Pedel,
            Direktør,
        }

        // Oprettelse af constructor med nedarv fra Person klasse:
        public Ansat(DateTime AnsatDato, int stillingID, string Adresse, string By, string Navn, int Post) : base (Adresse, By, Navn, Post)
        {
            this.AnsatDato = AnsatDato;
            this.StillingID = GetStilling(stillingID);
        }

        public Ansat()
        {

        }

        // Metode til at omdanne den angivne stilling (int) til den tilhørende streng-værdi:
        /// <summary>
        /// Converts "stillingID" (int) to the corresponding string, for human readability purposes.
        /// </summary>
        /// <param name="stillingID"></param>
        /// <returns>string</returns>
        static string GetStilling(int stillingID)
        {
            string stilling = Enum.GetName(typeof(Stilling), stillingID);
            return stilling;
        }

        // Metode til at liste alle ansatte
        /// <summary>
        /// Prints out all Ansat objects stored in the provided List.
        /// </summary>
        /// <param name="lAnsat"></param>
        public static void ListAnsatte(List<Ansat> lAnsat)
        {
            foreach (Ansat person in lAnsat)
            {
                Console.WriteLine($"Navn: {person.Navn}, Stilling: {person.StillingID}, Adresse: {person.Adresse}, {person.Post}, {person.By}. Ansat {person.AnsatDato.ToShortDateString()}");
            }
        }

        // Method to initialize test data, so it can be removed more easily later.
        public static List<Ansat> AnsatTestData()
        {
            List<Ansat> lAnsat = new List<Ansat>();
            lAnsat.Add(new Ansat(DateTime.Now, 1, "Hestvej", "Lars' Mark", "Karsten", 5555));
            lAnsat.Add(new Ansat { AnsatDato = DateTime.Now, Navn = "Jesper", Adresse = "Karstensvej", By = "Argos", Post = 1111, StillingID = GetStilling(2) });

            return lAnsat;
        }
    }
}
