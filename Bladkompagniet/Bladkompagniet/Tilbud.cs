using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    public class Tilbud
    {
        public DateTime fra;
        public DateTime til;
        public double amount;

        public static List<Tilbud> TilbudTestData()
        {
            List<Tilbud> lTilbud = new List<Tilbud>();
            lTilbud.Add(new Tilbud { fra = DateTime.Now.AddDays(-1), til = DateTime.Now.AddMonths(2), amount = 25 });

            return lTilbud;
        }

        public static void ListTilbud(List<Tilbud> lTilbud)
        {
            foreach (Tilbud t in lTilbud)
            {
                Console.WriteLine($"Rabat: {t.amount}%");
            }
        }
    }
}
