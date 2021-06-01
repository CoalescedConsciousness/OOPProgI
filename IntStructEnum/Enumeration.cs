using System;
using System.Collections.Generic;
using System.Text;

namespace IntStructEnum
{
    public class Enumeration
    {
        public enum Farve
        {
            Grøn,
            Blå,
            Rød,
            Gul,
        }

        public static void PrintFarve()
        {
            Farve minFarve = Farve.Grøn;
            Console.WriteLine(minFarve);
        }
    }
}
