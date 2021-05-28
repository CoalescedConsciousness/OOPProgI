using System;
using System.Collections.Generic;
using System.Text;

namespace Bog
{
    class Boghandler
    {
        public static void Sælg(Bog bog)
        {
            if (bog.InStore != 0)
            {
                Console.WriteLine($"Bogen {bog.Titel} er blevet solgt.");
                bog.InStore--;
                Console.WriteLine($"Der er nu {bog.InStore} eksemplarer tilbage.");
            }
        }
    }
}
