using System;
using System.Collections.Generic;


namespace Bladkompagniet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afvikel test-run af klasser og metoder:
            TestData();


        }

        static void TestData()
        {
            #region Initialisering og visning af data:
            // Ansat klassen:
            List<Ansat> lAnsat = Ansat.AnsatTestData();
            Ansat.ListAnsatte(lAnsat);

            // Kunde klassen:
            List<Kunde> lKunder = Kunde.KundeTestData();
            Kunde.ListKunder(lKunder);

            // Avis klassen:
            List<Avis> lAvis = Avis.AvisTestData();
            Avis.ListAviser(lAvis);

            // Abonnement klassen:
            List<Abonnement> lAbo = Abonnement.AboTestData(lAvis[0]);
            Abonnement.ListAbo(lAbo);

            // Tilbud klassen:
            List<Tilbud> lTilbud = Tilbud.TilbudTestData();
            Tilbud.ListTilbud(lTilbud);
            #endregion

            #region Test Rabat
            lAvis[0].GetTilbud(lTilbud[0]);
            Avis.ListAviser(lAvis);
            #endregion

            #region Test Tilføjelse af Abonnement
            lKunder[0].AddAbo(lAbo[0]);
            Kunde.ListKunder(lKunder);
            #endregion

        }


    }
}
