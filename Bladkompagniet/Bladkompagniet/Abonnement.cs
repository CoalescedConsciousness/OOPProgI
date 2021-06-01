using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    class Abonnement
    {
        public string Kunde { get; set; }
        public DateTime Udgivelse { get; set; }
        public bool Betalt { get; set; }
    }
}
